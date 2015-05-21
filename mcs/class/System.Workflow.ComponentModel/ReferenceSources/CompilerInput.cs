using System;
using System.Runtime.Serialization;
using System.Workflow.ComponentModel.Compiler;

namespace Microsoft.Workflow.Compiler
{
    [DataContract]
    internal class CompilerInput
    {
        [DataMember]
        private readonly WorkflowCompilerParameters parameters;

        [DataMember]
        private readonly string[] files;

        public string[] Files
        {
            get
            {
                return this.files;
            }
        }

        public WorkflowCompilerParameters Parameters
        {
            get
            {
                return this.parameters;
            }
        }

        public CompilerInput(WorkflowCompilerParameters parameters, string[] files)
        {
            this.parameters = parameters;
            this.files = files;
        }
    }
}
