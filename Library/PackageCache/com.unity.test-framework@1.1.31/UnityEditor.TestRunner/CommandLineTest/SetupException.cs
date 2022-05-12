<<<<<<< HEAD
using System;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    internal class SetupException : Exception
    {
        public ExceptionType Type { get; }
        public object[] Details { get; }

        public SetupException(ExceptionType type, params object[] details)
        {
            Type = type;
            Details = details;
        }

        public enum ExceptionType
        {
            ScriptCompilationFailed,
            PlatformNotFound,
            TestSettingsFileNotFound,
        }
    }
}
=======
using System;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    internal class SetupException : Exception
    {
        public ExceptionType Type { get; }
        public object[] Details { get; }

        public SetupException(ExceptionType type, params object[] details)
        {
            Type = type;
            Details = details;
        }

        public enum ExceptionType
        {
            ScriptCompilationFailed,
            PlatformNotFound,
            TestSettingsFileNotFound,
        }
    }
}
>>>>>>> d6a5058d (added player animation with movement)
