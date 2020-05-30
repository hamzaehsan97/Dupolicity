<<<<<<< HEAD
using System;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditModeLauncherContextSettings : IDisposable
    {
        private bool m_RunInBackground;

        public EditModeLauncherContextSettings()
        {
            SetupProjectParameters();
        }

        public void Dispose()
        {
            CleanupProjectParameters();
        }

        private void SetupProjectParameters()
        {
            m_RunInBackground = Application.runInBackground;
            Application.runInBackground = true;
        }

        private void CleanupProjectParameters()
        {
            Application.runInBackground = m_RunInBackground;
        }
    }
}
=======
using System;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditModeLauncherContextSettings : IDisposable
    {
        private bool m_RunInBackground;

        public EditModeLauncherContextSettings()
        {
            SetupProjectParameters();
        }

        public void Dispose()
        {
            CleanupProjectParameters();
        }

        private void SetupProjectParameters()
        {
            m_RunInBackground = Application.runInBackground;
            Application.runInBackground = true;
        }

        private void CleanupProjectParameters()
        {
            Application.runInBackground = m_RunInBackground;
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
