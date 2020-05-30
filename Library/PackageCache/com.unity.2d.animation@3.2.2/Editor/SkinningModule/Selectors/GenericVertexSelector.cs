<<<<<<< HEAD
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine.U2D.Interface;
using UnityEditor.U2D.Interface;
using System;
using System.Collections.Generic;

namespace UnityEditor.U2D.Animation
{
    internal class GenericVertexSelector : ISelector<int>
    {
        public ISelection<int> selection { get; set; }
        public ISpriteMeshData spriteMeshData { get; set; }
        public Func<int, bool> SelectionCallback;

        public void Select()
        {
            Debug.Assert(selection != null);
            Debug.Assert(spriteMeshData != null);
            Debug.Assert(SelectionCallback != null);

            for (var i = 0; i < spriteMeshData.vertexCount; i++)
                selection.Select(i, SelectionCallback(i));
        }
    }
}
=======
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine.U2D.Interface;
using UnityEditor.U2D.Interface;
using System;
using System.Collections.Generic;

namespace UnityEditor.U2D.Animation
{
    internal class GenericVertexSelector : ISelector<int>
    {
        public ISelection<int> selection { get; set; }
        public ISpriteMeshData spriteMeshData { get; set; }
        public Func<int, bool> SelectionCallback;

        public void Select()
        {
            Debug.Assert(selection != null);
            Debug.Assert(spriteMeshData != null);
            Debug.Assert(SelectionCallback != null);

            for (var i = 0; i < spriteMeshData.vertexCount; i++)
                selection.Select(i, SelectionCallback(i));
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
