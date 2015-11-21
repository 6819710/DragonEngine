using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dragon.Engine
{
    /// <summary>
    /// Defines Vector in 3D Space.
    /// </summary>
    public class Vector3D
    {
        private double _i;
        private double _j;
        private double _k;

        public Vector3D()
        {
            _i = 0;
            _j = 0;
            _k = 0;
        }

        public Vector3D(double i, double j, double k)
        {
            _i = i;
            _j = j;
            _k = k;
        }

        /// <summary>
        /// Property: I Coordinate.
        /// </summary>
        public double I
        {
            get
            {
                return _i;
            }

            set
            {
                _i = value;
            }
        }

        /// <summary>
        /// Property: J Coordinate.
        /// </summary>
        public double J
        {
            get
            {
                return _j;
            }

            set
            {
                _j = value;
            }
        }

        /// <summary>
        /// Property: K Coordinate.
        /// </summary>
        public double K
        {
            get
            {
                return _k;
            }

            set
            {
                _k = value;
            }
        }

        /// <summary>
        /// Property: Magnitude.
        /// </summary>
        public double Magnitude
        {
            get
            {
                return CalculateMagnitude();
            }
        }

        /// <summary>
        /// Converts Vector to Point in 3D Space.
        /// </summary>
        public Point3D Point3D
        {
            get
            {
                return new Point3D(_i, _j, _k);
            }
        }

        /// <summary>
        /// Calculates Vector Magnitude.
        /// </summary>
        /// <returns>Magnitude.</returns>
        public double CalculateMagnitude()
        {
            return Math.Sqrt(Math.Pow(_i, 2) + Math.Pow(_j, 2) + Math.Pow(_k, 2));
        }
    }
}