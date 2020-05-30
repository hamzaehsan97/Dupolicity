<<<<<<< HEAD
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools.TestRunner
{
    internal class InvalidSignatureException : ResultStateException
    {
        public InvalidSignatureException(string message)
            : base(message)
        {
        }

        public override ResultState ResultState
        {
            get { return ResultState.NotRunnable; }
        }
    }
}
=======
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools.TestRunner
{
    internal class InvalidSignatureException : ResultStateException
    {
        public InvalidSignatureException(string message)
            : base(message)
        {
        }

        public override ResultState ResultState
        {
            get { return ResultState.NotRunnable; }
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
