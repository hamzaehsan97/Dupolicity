<<<<<<< HEAD
namespace UnityEngine.U2D.Animation.TriangleNet
    .Meshing
{
    using Animation.TriangleNet.Geometry;

    /// <summary>
    /// Interface for polygon triangulation.
    /// </summary>
    internal interface IConstraintMesher
    {
        /// <summary>
        /// Triangulates a polygon.
        /// </summary>
        /// <param name="polygon">The polygon.</param>
        /// <returns>Mesh</returns>
        IMesh Triangulate(IPolygon polygon);

        /// <summary>
        /// Triangulates a polygon, applying constraint options.
        /// </summary>
        /// <param name="polygon">The polygon.</param>
        /// <param name="options">Constraint options.</param>
        /// <returns>Mesh</returns>
        IMesh Triangulate(IPolygon polygon, ConstraintOptions options);
    }
}
=======
namespace UnityEngine.U2D.Animation.TriangleNet
    .Meshing
{
    using Animation.TriangleNet.Geometry;

    /// <summary>
    /// Interface for polygon triangulation.
    /// </summary>
    internal interface IConstraintMesher
    {
        /// <summary>
        /// Triangulates a polygon.
        /// </summary>
        /// <param name="polygon">The polygon.</param>
        /// <returns>Mesh</returns>
        IMesh Triangulate(IPolygon polygon);

        /// <summary>
        /// Triangulates a polygon, applying constraint options.
        /// </summary>
        /// <param name="polygon">The polygon.</param>
        /// <param name="options">Constraint options.</param>
        /// <returns>Mesh</returns>
        IMesh Triangulate(IPolygon polygon, ConstraintOptions options);
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
