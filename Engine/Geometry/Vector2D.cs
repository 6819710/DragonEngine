using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dragon.Engine
{
    /// <summary>
    /// Defines Vector in 2D Space.
    /// </summary>
    public class Vector2D
    {
        private double _i;
        private double _j;

        /// <summary>
        /// Constucts Vector in 2D Space.
        /// </summary>
        public Vector2D()
        {
            _i = 0;
            _j = 0;
        }

        /// <summary>
        /// Constructs Vector in 2D Space.
        /// </summary>
        /// <param name="i">Magnitude in X-Axis.</param>
        /// <param name="j">Magnitude in Y-Axis.</param>
        public Vector2D(double i, double j)
        {
            _i = i;
            _j = j;
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
        /// Converts Vector to Point in 2D Space.
        /// </summary>
        public Point2D Point2D
        {
            get
            {
                return new Point2D(_i, _j);
            }
        }

        /// <summary>
        /// Calculates Vector Magnitude.
        /// </summary>
        /// <returns>Magnitude.</returns>
        public double CalculateMagnitude()
        {
            return Math.Sqrt(Math.Pow(_i, 2) + Math.Pow(_j, 2));
        }
    }
}