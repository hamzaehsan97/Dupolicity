<<<<<<< HEAD
﻿namespace UnityEngine.U2D.Animation
{
    internal class SpriteSkinManager
    {
        // Doing this to hide it from user adding it from Inspector
        [DefaultExecutionOrder(-1)]
        [ExecuteInEditMode]
        internal class SpriteSkinManagerInternal : MonoBehaviour
        {
#if ENABLE_ANIMATION_COLLECTION
            void LateUpdate()
            {
                if (SpriteSkinComposite.instance.helperGameObject != gameObject)
                {
                    GameObject.DestroyImmediate(gameObject);
                    return;
                }
                SpriteSkinComposite.instance.LateUpdate();
            }
#endif
        }
    }
}
=======
﻿namespace UnityEngine.U2D.Animation
{
    internal class SpriteSkinManager
    {
        // Doing this to hide it from user adding it from Inspector
        [DefaultExecutionOrder(-1)]
        [ExecuteInEditMode]
        internal class SpriteSkinManagerInternal : MonoBehaviour
        {
#if ENABLE_ANIMATION_COLLECTION
            void LateUpdate()
            {
                if (SpriteSkinComposite.instance.helperGameObject != gameObject)
                {
                    GameObject.DestroyImmediate(gameObject);
                    return;
                }
                SpriteSkinComposite.instance.LateUpdate();
            }
#endif
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
