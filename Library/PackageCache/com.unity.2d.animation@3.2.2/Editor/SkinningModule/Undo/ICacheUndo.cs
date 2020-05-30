<<<<<<< HEAD
namespace UnityEditor.U2D.Animation
{
    internal interface ICacheUndo
    {
        IUndo undoOverride { get; set; }
        bool isUndoOperationSet { get; }
        void IncrementCurrentGroup();
        void BeginUndoOperation(string name);
        void EndUndoOperation();
    }
}
=======
namespace UnityEditor.U2D.Animation
{
    internal interface ICacheUndo
    {
        IUndo undoOverride { get; set; }
        bool isUndoOperationSet { get; }
        void IncrementCurrentGroup();
        void BeginUndoOperation(string name);
        void EndUndoOperation();
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
