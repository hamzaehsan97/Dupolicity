<<<<<<< HEAD
using UnityEngine.UIElements;

namespace UnityEditor.U2D.Animation
{
    internal static class VisualElementExtensions
    {
        public static void SetHiddenFromLayout(this VisualElement element, bool isHidden)
        {
            if (isHidden)
            {
                element.SetEnabled(false);
                element.style.display = DisplayStyle.None;
                element.style.position = Position.Absolute;
            }
            else
            {
                element.SetEnabled(true);
                element.style.display = DisplayStyle.Flex;
                element.style.position = Position.Relative;
            }
        }
    }
}
=======
using UnityEngine.UIElements;

namespace UnityEditor.U2D.Animation
{
    internal static class VisualElementExtensions
    {
        public static void SetHiddenFromLayout(this VisualElement element, bool isHidden)
        {
            if (isHidden)
            {
                element.SetEnabled(false);
                element.style.display = DisplayStyle.None;
                element.style.position = Position.Absolute;
            }
            else
            {
                element.SetEnabled(true);
                element.style.display = DisplayStyle.Flex;
                element.style.position = Position.Relative;
            }
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
