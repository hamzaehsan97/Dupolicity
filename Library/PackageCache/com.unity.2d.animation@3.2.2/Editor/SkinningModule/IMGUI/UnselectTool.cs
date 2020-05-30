<<<<<<< HEAD
using System;
using UnityEngine;

namespace UnityEditor.U2D.Animation
{
    internal class UnselectTool<T>
    {
        private Unselector<T> m_Unselector = new Unselector<T>();
        public ICacheUndo cacheUndo { get; set; }
        public ISelection<T> selection
        {
            get { return m_Unselector.selection; }
            set { m_Unselector.selection = value; }
        }
        public Action onUnselect = () => {};

        public void OnGUI()
        {
            Debug.Assert(cacheUndo != null);
            Debug.Assert(selection != null);

            var e = Event.current;

            if (selection.Count > 0 && e.type == EventType.MouseDown && e.button == 1 && !e.alt)
            {
                cacheUndo.BeginUndoOperation(TextContent.clearSelection);
                m_Unselector.Select();
                e.Use();
                onUnselect.Invoke();
            }
        }
    }
}
=======
using System;
using UnityEngine;

namespace UnityEditor.U2D.Animation
{
    internal class UnselectTool<T>
    {
        private Unselector<T> m_Unselector = new Unselector<T>();
        public ICacheUndo cacheUndo { get; set; }
        public ISelection<T> selection
        {
            get { return m_Unselector.selection; }
            set { m_Unselector.selection = value; }
        }
        public Action onUnselect = () => {};

        public void OnGUI()
        {
            Debug.Assert(cacheUndo != null);
            Debug.Assert(selection != null);

            var e = Event.current;

            if (selection.Count > 0 && e.type == EventType.MouseDown && e.button == 1 && !e.alt)
            {
                cacheUndo.BeginUndoOperation(TextContent.clearSelection);
                m_Unselector.Select();
                e.Use();
                onUnselect.Invoke();
            }
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
