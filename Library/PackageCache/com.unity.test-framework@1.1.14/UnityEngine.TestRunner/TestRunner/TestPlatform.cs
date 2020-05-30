<<<<<<< HEAD
using System;

namespace UnityEngine.TestTools
{
    [Flags]
    [Serializable]
    public enum TestPlatform : byte
    {
        All = 0xFF,
        EditMode = 1 << 1,
        PlayMode = 1 << 2
    }

    internal static class TestPlatformEnumExtensions
    {
        public static bool IsFlagIncluded(this TestPlatform flags, TestPlatform flag)
        {
            return (flags & flag) == flag;
        }
    }
}
=======
using System;

namespace UnityEngine.TestTools
{
    [Flags]
    [Serializable]
    public enum TestPlatform : byte
    {
        All = 0xFF,
        EditMode = 1 << 1,
        PlayMode = 1 << 2
    }

    internal static class TestPlatformEnumExtensions
    {
        public static bool IsFlagIncluded(this TestPlatform flags, TestPlatform flag)
        {
            return (flags & flag) == flag;
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
