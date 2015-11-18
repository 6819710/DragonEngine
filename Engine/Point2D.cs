using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dragon.Engine
{
    /// <summary>
    /// Defines Points in 2D Space.
    /// </summary>
    public class Point2D
    {
        private double _x;
        private double _y;

        /// <summary>
        /// Constructs Point in 2D Space.
        /// </summary>
        public Point2D()
        {
            _x = 0;
            _y = 0;
        }

        /// <summary>
        /// Constructs Point in 2D Space.
        /// </summary>
        /// <param name="x">X Coordinate.</param>
        /// <param name="y">Y Coordinate.</param>
        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;
        }
    }
}