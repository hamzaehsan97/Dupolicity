<<<<<<< HEAD
using UnityEditor.Scripting.ScriptCompilation;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditorCompilationInterfaceProxy : IEditorCompilationInterfaceProxy
    {
        public ScriptAssembly[] GetAllEditorScriptAssemblies()
        {
            return EditorCompilationInterface.Instance.GetAllEditorScriptAssemblies(EditorCompilationInterface.GetAdditionalEditorScriptCompilationOptions());
        }

        public PrecompiledAssembly[] GetAllPrecompiledAssemblies()
        {
            return EditorCompilationInterface.Instance.GetAllPrecompiledAssemblies();
        }
    }
}
=======
using UnityEditor.Scripting.ScriptCompilation;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditorCompilationInterfaceProxy : IEditorCompilationInterfaceProxy
    {
        public ScriptAssembly[] GetAllEditorScriptAssemblies()
        {
            return EditorCompilationInterface.Instance.GetAllEditorScriptAssemblies(EditorCompilationInterface.GetAdditionalEditorScriptCompilationOptions());
        }

        public PrecompiledAssembly[] GetAllPrecompiledAssemblies()
        {
            return EditorCompilationInterface.Instance.GetAllPrecompiledAssemblies();
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
