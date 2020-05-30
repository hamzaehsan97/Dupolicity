<<<<<<< HEAD
using System;
using System.Collections;
using UnityEditor.SceneManagement;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class SaveModiedSceneTask : TestTaskBase
    {
        internal Func<bool> SaveCurrentModifiedScenesIfUserWantsTo =
            EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo;
        public override IEnumerator Execute(TestJobData testJobData)
        {
            var cancelled = !SaveCurrentModifiedScenesIfUserWantsTo();
            if (cancelled)
            {
                throw new TestRunCanceledException();
            }

            yield break;
        }
    }
=======
using System;
using System.Collections;
using UnityEditor.SceneManagement;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class SaveModiedSceneTask : TestTaskBase
    {
        internal Func<bool> SaveCurrentModifiedScenesIfUserWantsTo =
            EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo;
        public override IEnumerator Execute(TestJobData testJobData)
        {
            var cancelled = !SaveCurrentModifiedScenesIfUserWantsTo();
            if (cancelled)
            {
                throw new TestRunCanceledException();
            }

            yield break;
        }
    }
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
}