<<<<<<< HEAD
namespace UnityEditor.U2D.Animation
{
    internal interface ISelection<T>
    {
        int Count { get; }
        T activeElement { get; set; }
        T[] elements { get; set; }
        void Clear();
        void BeginSelection();
        void EndSelection(bool select);
        void Select(T element, bool select);
        bool Contains(T element);
    }
}
=======
namespace UnityEditor.U2D.Animation
{
    internal interface ISelection<T>
    {
        int Count { get; }
        T activeElement { get; set; }
        T[] elements { get; set; }
        void Clear();
        void BeginSelection();
        void EndSelection(bool select);
        void Select(T element, bool select);
        bool Contains(T element);
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
