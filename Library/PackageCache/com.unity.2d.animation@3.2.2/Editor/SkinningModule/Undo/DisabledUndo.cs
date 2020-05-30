<<<<<<< HEAD
using UnityEngine;
using UnityEditor;

namespace UnityEditor.U2D.Animation
{
    internal class DisabledUndo : IUndo
    {
        public void RecordObject(object o, string name) {}
        public void RegisterCompleteObjectUndo(object o, string name) {}
        public void RegisterCompleteObjectUndo(object[] o, string name) {}
        public void RegisterCreatedObjectUndo(object o, string name) {}
        public void DestroyObjectImmediate(object o)
        {
            BaseObject.DestroyImmediate(o);
        }

        public void ClearUndo(object o) {}
        public void IncrementCurrentGroup() {}
    }
}
=======
using UnityEngine;
using UnityEditor;

namespace UnityEditor.U2D.Animation
{
    internal class DisabledUndo : IUndo
    {
        public void RecordObject(object o, string name) {}
        public void RegisterCompleteObjectUndo(object o, string name) {}
        public void RegisterCompleteObjectUndo(object[] o, string name) {}
        public void RegisterCreatedObjectUndo(object o, string name) {}
        public void DestroyObjectImmediate(object o)
        {
            BaseObject.DestroyImmediate(o);
        }

        public void ClearUndo(object o) {}
        public void IncrementCurrentGroup() {}
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
