<<<<<<< HEAD
using System.Collections;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools
{
    /// <summary>
    /// When implemented by an attribute, this interface implemented to provide actions to execute before setup and after teardown of tests.
    /// </summary>
    public interface IOuterUnityTestAction
    {
        /// <summary>Executed before each test is run</summary>
        /// <param name="test">The test that is going to be run.</param>
        IEnumerator BeforeTest(ITest test);

        /// <summary>Executed after each test is run</summary>
        /// <param name="test">The test that has just been run.</param>
        IEnumerator AfterTest(ITest test);
    }
}
=======
using System.Collections;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools
{
    /// <summary>
    /// When implemented by an attribute, this interface implemented to provide actions to execute before setup and after teardown of tests.
    /// </summary>
    public interface IOuterUnityTestAction
    {
        /// <summary>Executed before each test is run</summary>
        /// <param name="test">The test that is going to be run.</param>
        IEnumerator BeforeTest(ITest test);

        /// <summary>Executed after each test is run</summary>
        /// <param name="test">The test that has just been run.</param>
        IEnumerator AfterTest(ITest test);
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
