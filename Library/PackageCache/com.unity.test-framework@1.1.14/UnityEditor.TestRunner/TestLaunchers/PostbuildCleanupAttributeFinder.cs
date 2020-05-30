<<<<<<< HEAD
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    internal class PostbuildCleanupAttributeFinder : AttributeFinderBase<IPostBuildCleanup, PostBuildCleanupAttribute>
    {
        public PostbuildCleanupAttributeFinder() : base(attribute => attribute.TargetClass) {}
    }
}
=======
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    internal class PostbuildCleanupAttributeFinder : AttributeFinderBase<IPostBuildCleanup, PostBuildCleanupAttribute>
    {
        public PostbuildCleanupAttributeFinder() : base(attribute => attribute.TargetClass) {}
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
