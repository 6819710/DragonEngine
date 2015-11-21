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
    public class Vector3DTests
    {
        [Test()]
        public void Vector3DTestDefault()
        {
            Vector3D test = new Vector3D();

            Assert.IsInstanceOf<Vector3D>(test);
            Assert.AreEqual(0, test.I);
            Assert.AreEqual(0, test.J);
            Assert.AreEqual(0, test.K);
        }

        [Test()]
        public void Vector3DTestValues()
        {
            Vector3D test = new Vector3D(1, 2, 3);

            Assert.IsInstanceOf<Vector3D>(test);
            Assert.AreEqual(1, test.I);
            Assert.AreEqual(2, test.J);
            Assert.AreEqual(3, test.K);
        }
    }
}