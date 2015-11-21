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
    public class Point2DTests
    {
        [Test()]
        public void Point2DTestDefault()
        {
            Point2D test = new Point2D();

            Assert.IsInstanceOf<Point2D>(test);
            Assert.AreEqual(0, test.X);
            Assert.AreEqual(0, test.Y);
        }

        [Test()]
        public void Point2DTestValues()
        {
            Point2D test = new Point2D(3, 4);

            Assert.IsInstanceOf<Point2D>(test);
            Assert.AreEqual(3, test.X);
            Assert.AreEqual(4, test.Y);
        }
    }
}