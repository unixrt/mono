using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Workflow.ComponentModel.Compiler;
using System.Xml;

namespace Microsoft.Workflow.Compiler
{
    [Obsolete("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
    public sealed class CompilerWrapper
    {
        private static string compilerPath;

        private WorkflowCompilerResults results;

        private static string CompilerPath
        {
            get
            {
                if (CompilerWrapper.compilerPath == null)
                {
                    CompilerWrapper.compilerPath = string.Format("{0}\\Microsoft.Workflow.Compiler.exe", RuntimeEnvironment.GetRuntimeDirectory());
                }
                return CompilerWrapper.compilerPath;
            }
        }

        static CompilerWrapper()
        {
        }

        public CompilerWrapper()
        {
        }

        public WorkflowCompilerResults Compile(WorkflowCompilerParameters parameters, params string[] files)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (files == null)
            {
                throw new ArgumentNullException("files");
            }
            if (!EnvironmentExtension.Is64BitOS() || !EnvironmentExtension.IsWowProcess())
            {
                this.CompileInSameProcess(parameters, files);
            }
            else if (!CompilerWrapper.Has64bitAssembliesInReferences(parameters))
            {
                this.CompileInSameProcess(parameters, files);
            }
            else
            {
                this.CompileInSeparateProcess(parameters, files);
            }
            return this.results;
        }

        private void CompileInSameProcess(WorkflowCompilerParameters parameters, string[] files)
        {
            this.results = (new WorkflowCompiler()).Compile(parameters, files);
        }

        private void CompileInSeparateProcess(WorkflowCompilerParameters parameters, string[] files)
        {
            string wrapper = CompilerWrapper.SerializeInputToWrapper(parameters, files);
            string tempFileName = Path.GetTempFileName();
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo(CompilerWrapper.CompilerPath)
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    ErrorDialog = false,
                    Arguments = string.Format("\"{0}\" \"{1}\"", wrapper, tempFileName)
                };
                Process process = new Process()
                {
                    StartInfo = processStartInfo
                };
                process.Start();
                process.WaitForExit();
                this.results = CompilerWrapper.DeserializeWrapperOutput(tempFileName);
            }
            finally
            {
                File.Delete(wrapper);
                File.Delete(tempFileName);
            }
        }

        private static WorkflowCompilerResults DeserializeWrapperOutput(string fileName)
        {
            WorkflowCompilerResults workflowCompilerResult;
            using (Stream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (XmlReader xmlReader = XmlReader.Create(fileStream))
                {
                    NetDataContractSerializer netDataContractSerializer = new NetDataContractSerializer();
                    SurrogateSelector surrogateSelector = new SurrogateSelector();
                    surrogateSelector.AddSurrogate(typeof(MemberAttributes), netDataContractSerializer.Context, new CompilerResultsSurrogate());
                    ((IFormatter)netDataContractSerializer).SurrogateSelector = surrogateSelector;
                    workflowCompilerResult = (WorkflowCompilerResults)netDataContractSerializer.ReadObject(xmlReader);
                }
            }
            return workflowCompilerResult;
        }

        private static bool Has64bitAssembliesInReferences(WorkflowCompilerParameters parameters)
        {
            for (int i = 0; i < parameters.ReferencedAssemblies.Count; i++)
            {
                if (PEHeader.Is64BitRequiredExecutable(parameters.ReferencedAssemblies[i]))
                {
                    return true;
                }
            }
            return false;
        }

        private static string SerializeInputToWrapper(WorkflowCompilerParameters parameters, string[] files)
        {
            string tempFileName = Path.GetTempFileName();
            using (Stream fileStream = new FileStream(tempFileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                XmlWriterSettings xmlWriterSetting = new XmlWriterSettings()
                {
                    Indent = true
                };
                using (XmlWriter xmlWriter = XmlWriter.Create(fileStream, xmlWriterSetting))
                {
                    CompilerInput compilerInput = new CompilerInput(MultiTargetingInfo.MultiTargetingUtilities.NormalizeReferencedAssemblies(parameters), files);
                    (new DataContractSerializer(typeof(CompilerInput))).WriteObject(xmlWriter, compilerInput);
                }
            }
            return tempFileName;
        }
    }
}
