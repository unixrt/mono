using System;

namespace Microsoft.Workflow.Compiler
{
    internal static class EnvironmentExtension
    {
        private static bool? is64BitOS;

        private static bool? isWowProcess;

        private static bool CheckIf64BitOS()
        {
            return Environment.Is64BitOperatingSystem;
        }

        private static bool CheckIfWowProcess()
        {
            if (!EnvironmentExtension.Is64BitOS())
            {
                return false;
            }
            return !Environment.Is64BitProcess;
        }

        public static bool Is64BitOS()
        {
            if (!EnvironmentExtension.is64BitOS.HasValue)
            {
                EnvironmentExtension.is64BitOS = new bool?(EnvironmentExtension.CheckIf64BitOS());
            }
            return EnvironmentExtension.is64BitOS.Value;
        }

        public static bool IsWowProcess()
        {
            if (!EnvironmentExtension.isWowProcess.HasValue)
            {
                EnvironmentExtension.isWowProcess = new bool?(EnvironmentExtension.CheckIfWowProcess());
            }
            return EnvironmentExtension.isWowProcess.Value;
        }
    }
}
