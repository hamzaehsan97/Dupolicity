<<<<<<< HEAD
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    interface ITestListCache
    {
        void CacheTest(TestPlatform platform, ITest test);
        IEnumerator<ITestAdaptor> GetTestFromCacheAsync(TestPlatform platform);
    }
}
=======
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    interface ITestListCache
    {
        void CacheTest(TestPlatform platform, ITest test);
        IEnumerator<ITestAdaptor> GetTestFromCacheAsync(TestPlatform platform);
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
