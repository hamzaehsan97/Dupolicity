<<<<<<< HEAD
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.U2D.Animation
{
    internal interface ITransformSelection<T> : ISelection<T> where T : TransformCache
    {
        T root { get; }
        T[] roots { get; }
    }
}
=======
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.U2D.Animation
{
    internal interface ITransformSelection<T> : ISelection<T> where T : TransformCache
    {
        T root { get; }
        T[] roots { get; }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
