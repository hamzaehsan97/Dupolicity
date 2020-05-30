<<<<<<< HEAD
namespace UnityEditor.U2D.Animation
{
    internal interface IUndo
    {
        void RecordObject(object o, string name);
        void RegisterCompleteObjectUndo(object o, string name);
        void RegisterCompleteObjectUndo(object[] o, string name);
        void RegisterCreatedObjectUndo(object o, string name);
        void DestroyObjectImmediate(object o);
        void ClearUndo(object o);
        void IncrementCurrentGroup();
    }
}
=======
namespace UnityEditor.U2D.Animation
{
    internal interface IUndo
    {
        void RecordObject(object o, string name);
        void RegisterCompleteObjectUndo(object o, string name);
        void RegisterCompleteObjectUndo(object[] o, string name);
        void RegisterCreatedObjectUndo(object o, string name);
        void DestroyObjectImmediate(object o);
        void ClearUndo(object o);
        void IncrementCurrentGroup();
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
