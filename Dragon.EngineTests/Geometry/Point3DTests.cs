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
    public class Point3DTests
    {
        [Test()]
        public void Point3DTestDefault()
        {
            Point3D test = new Point3D();

            Assert.IsInstanceOf<Point3D>(test);
            Assert.AreEqual(0, test.X);
            Assert.AreEqual(0, test.Y);
            Assert.AreEqual(0, test.Z);
        }

        [Test()]
        public void Point3DTestValues()
        {
            Point3D test = new Point3D(3, 4, 5);

            Assert.IsInstanceOf<Point3D>(test);
            Assert.AreEqual(3, test.X);
            Assert.AreEqual(4, test.Y);
            Assert.AreEqual(5, test.Z);
        }
    }
}