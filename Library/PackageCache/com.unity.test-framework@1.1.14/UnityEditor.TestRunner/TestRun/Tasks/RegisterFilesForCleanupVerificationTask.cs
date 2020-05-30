<<<<<<< HEAD
using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class RegisterFilesForCleanupVerificationTask : FileCleanupVerifierTaskBase
    {
        public override IEnumerator Execute(TestJobData testJobData)
        {
            testJobData.existingFiles = GetAllFilesInAssetsDirectory();
            yield return null;
        }
    }
=======
using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class RegisterFilesForCleanupVerificationTask : FileCleanupVerifierTaskBase
    {
        public override IEnumerator Execute(TestJobData testJobData)
        {
            testJobData.existingFiles = GetAllFilesInAssetsDirectory();
            yield return null;
        }
    }
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
}