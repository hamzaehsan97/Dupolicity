<<<<<<< HEAD
using System.Reflection;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditorAssemblyWrapper : AssemblyWrapper
    {
        public EditorAssemblyWrapper(Assembly assembly)
            : base(assembly) {}

        public override AssemblyName[] GetReferencedAssemblies()
        {
            return Assembly.GetReferencedAssemblies();
        }

        public override string Location { get { return Assembly.Location; } }
    }
}
=======
using System.Reflection;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditorAssemblyWrapper : AssemblyWrapper
    {
        public EditorAssemblyWrapper(Assembly assembly)
            : base(assembly) {}

        public override AssemblyName[] GetReferencedAssemblies()
        {
            return Assembly.GetReferencedAssemblies();
        }

        public override string Location { get { return Assembly.Location; } }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
