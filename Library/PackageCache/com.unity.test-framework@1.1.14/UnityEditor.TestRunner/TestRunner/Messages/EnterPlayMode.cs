<<<<<<< HEAD
using System;
using System.Collections;
using UnityEditor;

namespace UnityEngine.TestTools
{
    public class EnterPlayMode : IEditModeTestYieldInstruction
    {
        public bool ExpectDomainReload { get; }
        public bool ExpectedPlaymodeState { get; private set; }

        public EnterPlayMode(bool expectDomainReload = true)
        {
            ExpectDomainReload = expectDomainReload;
        }

        public IEnumerator Perform()
        {
            if (EditorApplication.isPlaying)
            {
                throw new Exception("Editor is already in PlayMode");
            }
            if (EditorUtility.scriptCompilationFailed)
            {
                throw new Exception("Script compilation failed");
            }
            yield return null;
            ExpectedPlaymodeState = true;

            EditorApplication.UnlockReloadAssemblies();
            EditorApplication.isPlaying = true;

            while (!EditorApplication.isPlaying)
            {
                yield return null;
            }
        }
    }
}
=======
using System;
using System.Collections;
using UnityEditor;

namespace UnityEngine.TestTools
{
    public class EnterPlayMode : IEditModeTestYieldInstruction
    {
        public bool ExpectDomainReload { get; }
        public bool ExpectedPlaymodeState { get; private set; }

        public EnterPlayMode(bool expectDomainReload = true)
        {
            ExpectDomainReload = expectDomainReload;
        }

        public IEnumerator Perform()
        {
            if (EditorApplication.isPlaying)
            {
                throw new Exception("Editor is already in PlayMode");
            }
            if (EditorUtility.scriptCompilationFailed)
            {
                throw new Exception("Script compilation failed");
            }
            yield return null;
            ExpectedPlaymodeState = true;

            EditorApplication.UnlockReloadAssemblies();
            EditorApplication.isPlaying = true;

            while (!EditorApplication.isPlaying)
            {
                yield return null;
            }
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
