using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dragon.Engine.Mathematics
{
    /// <summary>
    /// Provides Transformation Tools.
    /// </summary>
    public static class Transformation
    {
        /// <summary>
        /// Translates Given Point by Given Vector
        /// </summary>
        /// <param name="point">Point to Offset.</param>
        /// <param name="vector">Offset Vector.</param>
        /// <returns>Point2D.</returns>
        public static Point2D TranslatePoint2D(Point2D point, Vector2D vector)
        {
            return new Point2D(point.X + vector.I, point.Y + vector.J);
        }

        /// <summary>
        /// Rotates Given Point about Origin by Given Angle in Radians.
        /// </summary>
        /// <param name="Angle">Angle in Radians.</param>
        /// <returns>Point2D.</returns>
        public static Point2D RotatePoint2D(double Angle)
        {
            return new Point2D
        }
    }
}