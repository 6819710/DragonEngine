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

        public Matrix2D()
        {
            _a1 = 1;
            _a2 = 0;
            _b1 = 0;
            _b2 = 1;
        }

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