<<<<<<< HEAD
using System;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestRunner.TestLaunchers
{
    internal interface IRemoteTestResultDataFactory
    {
        RemoteTestResultDataWithTestData CreateFromTestResult(ITestResult result);
        RemoteTestResultDataWithTestData CreateFromTest(ITest test);
    }
}
=======
using System;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestRunner.TestLaunchers
{
    internal interface IRemoteTestResultDataFactory
    {
        RemoteTestResultDataWithTestData CreateFromTestResult(ITestResult result);
        RemoteTestResultDataWithTestData CreateFromTest(ITest test);
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
