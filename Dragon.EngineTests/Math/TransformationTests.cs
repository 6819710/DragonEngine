using NUnit.Framework;
using Dragon.Engine.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Engine.Mathematics.Tests
{
    [TestFixture()]
    public class TransformationTests
    {
        [Test()]
        public void TranslatePoint2DTest()
        {
            Point2D testPoint = new Point2D(2, 3);
            Vector2D testVector = new Vector2D(1, 2);

            Point2D result = Transformation.TranslatePoint2D(testPoint, testVector);

            Assert.AreEqual(3, result.X);
            Assert.AreEqual(5, result.Y);
        }
    }
}