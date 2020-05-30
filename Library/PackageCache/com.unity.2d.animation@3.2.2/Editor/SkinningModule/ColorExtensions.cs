<<<<<<< HEAD
using UnityEngine;
using UnityEditor;
using System;
using System.Collections.Generic;
using UnityEngine.U2D;

namespace UnityEditor.U2D.Animation
{
    internal static class ColorExtensions
    {
        public static Color AlphaMultiplied(this Color c, float multiplier)
        {
            return new Color(c.r, c.g, c.b, c.a * multiplier);
        }
    }
}
=======
using UnityEngine;
using UnityEditor;
using System;
using System.Collections.Generic;
using UnityEngine.U2D;

namespace UnityEditor.U2D.Animation
{
    internal static class ColorExtensions
    {
        public static Color AlphaMultiplied(this Color c, float multiplier)
        {
            return new Color(c.r, c.g, c.b, c.a * multiplier);
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
