<<<<<<< HEAD
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.U2D.Animation
{
    internal interface ITriangulator
    {
        void Triangulate(IList<Vector2> vertices, IList<Edge> edges, IList<int> indices);
        void Tessellate(float minAngle, float maxAngle, float meshAreaFactor, float largestTriangleAreaFactor, int smoothIterations, IList<Vector2> vertices, IList<Edge> edges, IList<int> indices);
    }
}
=======
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.U2D.Animation
{
    internal interface ITriangulator
    {
        void Triangulate(IList<Vector2> vertices, IList<Edge> edges, IList<int> indices);
        void Tessellate(float minAngle, float maxAngle, float meshAreaFactor, float largestTriangleAreaFactor, int smoothIterations, IList<Vector2> vertices, IList<Edge> edges, IList<int> indices);
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
