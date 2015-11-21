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
        /// <param name="x">X Coordinate.</param>
        /// <param name="y">Y Coordinate.</param>
        /// <param name="z">Z Coordinate.</param>
        public Point3D(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        /// <summary>
        /// Property: X Coordinate.
        /// </summary>
        public double X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }

        /// <summary>
        /// Property: Y Coordinate.
        /// </summary>
        public double Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }

        /// <summary>
        /// Property: Z Coordinate.
        /// </summary>
        public double Z
        {
            get
            {
                return _z;
            }

            set
            {
                _z = value;
            }
        }

        /// <summary>
        /// Converts Point to Vector in 3D Space.
        /// </summary>
        public Vector3D Vector3D
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    }
}