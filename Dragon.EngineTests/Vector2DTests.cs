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
    public class Vector2DTests
    {
        [Test()]
        public void Vector2DTestDefault()
        {
            Vector2D test = new Vector2D();

            Assert.IsInstanceOf<Vector2D>(test);
            Assert.AreEqual(0, test.I);
            Assert.AreEqual(0, test.J);
        }

        [Test()]
        public void Vector2DTestValues()
        {
            Vector2D test = new Vector2D(3, 4);

            Assert.IsInstanceOf<Vector2D>(test);
            Assert.AreEqual(3, test.I);
            Assert.AreEqual(4, test.J);
        }
    }
}