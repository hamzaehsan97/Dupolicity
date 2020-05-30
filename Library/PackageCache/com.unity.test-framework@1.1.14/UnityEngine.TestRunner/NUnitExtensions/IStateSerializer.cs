<<<<<<< HEAD
using System;

namespace UnityEngine.TestTools.NUnitExtensions
{
    internal interface IStateSerializer
    {
        ScriptableObject RestoreScriptableObjectInstance();
        void RestoreClassFromJson(ref object instance);
        bool CanRestoreFromJson(Type requestedType);
        bool CanRestoreFromScriptableObject(Type requestedType);
    }
}
=======
using System;

namespace UnityEngine.TestTools.NUnitExtensions
{
    internal interface IStateSerializer
    {
        ScriptableObject RestoreScriptableObjectInstance();
        void RestoreClassFromJson(ref object instance);
        bool CanRestoreFromJson(Type requestedType);
        bool CanRestoreFromScriptableObject(Type requestedType);
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
