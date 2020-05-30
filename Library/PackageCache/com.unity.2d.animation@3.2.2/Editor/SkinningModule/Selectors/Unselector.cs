<<<<<<< HEAD
using UnityEngine;

namespace UnityEditor.U2D.Animation
{
    internal class Unselector<T> : ISelector<T>
    {
        public ISelection<T> selection { get; set; }

        public void Select()
        {
            selection.Clear();
        }
    }
}
=======
using UnityEngine;

namespace UnityEditor.U2D.Animation
{
    internal class Unselector<T> : ISelector<T>
    {
        public ISelection<T> selection { get; set; }

        public void Select()
        {
            selection.Clear();
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
