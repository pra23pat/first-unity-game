<<<<<<< HEAD
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    internal class RunSettings : ITestRunSettings
    {
        private ITestSettings m_TestSettings;
        public RunSettings(ITestSettings testSettings)
        {
            this.m_TestSettings = testSettings;
        }

        public void Apply()
        {
            if (m_TestSettings != null)
            {
                m_TestSettings.SetupProjectParameters();
            }
        }

        public void Dispose()
        {
            if (m_TestSettings != null)
            {
                m_TestSettings.Dispose();
            }
        }
    }
}
=======
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    internal class RunSettings : ITestRunSettings
    {
        private ITestSettings m_TestSettings;
        public RunSettings(ITestSettings testSettings)
        {
            this.m_TestSettings = testSettings;
        }

        public void Apply()
        {
            if (m_TestSettings != null)
            {
                m_TestSettings.SetupProjectParameters();
            }
        }

        public void Dispose()
        {
            if (m_TestSettings != null)
            {
                m_TestSettings.Dispose();
            }
        }
    }
}
>>>>>>> d6a5058d (added player animation with movement)
