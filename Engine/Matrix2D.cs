using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dragon.Engine
{
    /// <summary>
    /// Defines 2D Matrix (2x2)
    /// |a1  a2|
    /// |b1  b2|
    /// </summary>
    public class Matrix2D
    {
        private double _a1;
        private double _a2;
        private double _b1;
        private double _b2;

        /// <summary>
        /// Constructs 2D matrix (2 x 2) using default values.
        /// </summary>
        public Matrix2D()
        {
            _a1 = 1;
            _a2 = 0;
            _b1 = 0;
            _b2 = 1;
        }

        /// <summary>
        /// Constructs 2D matrix (2 x 2) using provided values.
        /// </summary>
        /// <param name="a1">Row A Column 1.</param>
        /// <param name="a2">Row A Column 2.</param>
        /// <param name="b1">Row B Column 1.</param>
        /// <param name="b2">Row B Column 2.</param>
        public Matrix2D(double a1, double a2,
                        double b1, double b2)
        {
            _a1 = a1;
            _a2 = a2;
            _b1 = b1;
            _b2 = b2;
        }
    }
}