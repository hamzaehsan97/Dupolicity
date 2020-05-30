<<<<<<< HEAD
using System.Linq;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditorAssembliesProxy : IEditorAssembliesProxy
    {
        public IAssemblyWrapper[] loadedAssemblies
        {
            get { return EditorAssemblies.loadedAssemblies.OrderBy(a => a.FullName).Select(x => new EditorAssemblyWrapper(x)).ToArray(); }
        }
    }
}
=======
using System.Linq;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditorAssembliesProxy : IEditorAssembliesProxy
    {
        public IAssemblyWrapper[] loadedAssemblies
        {
            get { return EditorAssemblies.loadedAssemblies.OrderBy(a => a.FullName).Select(x => new EditorAssemblyWrapper(x)).ToArray(); }
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
