<<<<<<< HEAD
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools.TestRunner
{
    internal class UnityTestTimeoutException : ResultStateException
    {
        public UnityTestTimeoutException(int timeout)
            : base(BuildMessage(timeout))
        {
        }

        private static string BuildMessage(int timeout)
        {
            return string.Format("UnityTest exceeded Timeout value of {0}ms", timeout);
        }

        public override ResultState ResultState
        {
            get { return ResultState.Failure; }
        }

        public override string StackTrace
        {
            get { return ""; }
        }
    }
}
=======
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools.TestRunner
{
    internal class UnityTestTimeoutException : ResultStateException
    {
        public UnityTestTimeoutException(int timeout)
            : base(BuildMessage(timeout))
        {
        }

        private static string BuildMessage(int timeout)
        {
            return string.Format("UnityTest exceeded Timeout value of {0}ms", timeout);
        }

        public override ResultState ResultState
        {
            get { return ResultState.Failure; }
        }

        public override string StackTrace
        {
            get { return ""; }
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
