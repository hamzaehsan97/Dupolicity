<<<<<<< HEAD
namespace UnityEngine.TestTools
{
    public class MonoBehaviourTest<T> : CustomYieldInstruction where T : MonoBehaviour, IMonoBehaviourTest
    {
        public T component { get; }
        public GameObject gameObject { get { return component.gameObject; } }

        public MonoBehaviourTest(bool dontDestroyOnLoad = true)
        {
            var go = new GameObject("MonoBehaviourTest: " + typeof(T).FullName);
            component = go.AddComponent<T>();
            if (dontDestroyOnLoad)
            {
                Object.DontDestroyOnLoad(go);
            }
        }

        public override bool keepWaiting
        {
            get { return !component.IsTestFinished; }
        }
    }
}
=======
namespace UnityEngine.TestTools
{
    public class MonoBehaviourTest<T> : CustomYieldInstruction where T : MonoBehaviour, IMonoBehaviourTest
    {
        public T component { get; }
        public GameObject gameObject { get { return component.gameObject; } }

        public MonoBehaviourTest(bool dontDestroyOnLoad = true)
        {
            var go = new GameObject("MonoBehaviourTest: " + typeof(T).FullName);
            component = go.AddComponent<T>();
            if (dontDestroyOnLoad)
            {
                Object.DontDestroyOnLoad(go);
            }
        }

        public override bool keepWaiting
        {
            get { return !component.IsTestFinished; }
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
