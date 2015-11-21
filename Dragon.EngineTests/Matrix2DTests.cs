using NUnit.Framework;
using Dragon.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Engine.Tests
{
    [TestFixture()]
    public class Matrix2DTests
    {
        [Test()]
        public void Matrix2DTestDefault()
        {
            Matrix2D test = new Matrix2D();

            Assert.IsInstanceOf<Matrix2D>(test);
            Assert.AreEqual(1, test.A1);
            Assert.AreEqual(0, test.A2);
            Assert.AreEqual(0, test.B1);
            Assert.AreEqual(1, test.B2);
        }

        [Test()]
        public void Matrix2DTestValues()
        {
            Matrix2D test = new Matrix2D(1, 2, 3, 4);

            Assert.IsInstanceOf<Matrix2D>(test);
            Assert.AreEqual(1, test.A1);
            Assert.AreEqual(2, test.A2);
            Assert.AreEqual(3, test.B1);
            Assert.AreEqual(4, test.B2);
        }
    }
}