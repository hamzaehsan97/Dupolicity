<<<<<<< HEAD
namespace UnityEditor.TestTools.TestRunner
{
    internal class TestRunnerWindowSettings
    {
        public bool verticalSplit;

        private readonly string m_PrefsKey;

        public TestRunnerWindowSettings(string prefsKey)
        {
            m_PrefsKey = prefsKey;
            verticalSplit = EditorPrefs.GetBool(m_PrefsKey + ".verticalSplit", true);
        }

        public void ToggleVerticalSplit()
        {
            verticalSplit = !verticalSplit;
            Save();
        }

        private void Save()
        {
            EditorPrefs.SetBool(m_PrefsKey + ".verticalSplit", verticalSplit);
        }
    }
}
=======
namespace UnityEditor.TestTools.TestRunner
{
    internal class TestRunnerWindowSettings
    {
        public bool verticalSplit;

        private readonly string m_PrefsKey;

        public TestRunnerWindowSettings(string prefsKey)
        {
            m_PrefsKey = prefsKey;
            verticalSplit = EditorPrefs.GetBool(m_PrefsKey + ".verticalSplit", true);
        }

        public void ToggleVerticalSplit()
        {
            verticalSplit = !verticalSplit;
            Save();
        }

        private void Save()
        {
            EditorPrefs.SetBool(m_PrefsKey + ".verticalSplit", verticalSplit);
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
