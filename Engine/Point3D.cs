using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dragon.Engine
{
    /// <summary>
    /// Defines Points in 3D Space.
    /// </summary>
    public class Point3D
    {
        private double _x;
        private double _y;
        private double _z;

        /// <summary>
        /// Constructs Point in 3D Space.
        /// </summary>
        public Point3D()
        {
            _x = 0;
            _y = 0;
            _z = 0;
        }

        /// <summary>
        /// Constucts Point in 3D Space.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Point3D(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }
    }
}