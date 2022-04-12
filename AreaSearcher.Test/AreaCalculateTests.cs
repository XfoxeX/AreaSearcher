using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaSearcher;
using AreaSearcher.Figures;

namespace AreaSearcher.Test
{
    [TestClass]
    public class AreaCalculateTests
    {
        /// <summary>
        /// Сalculating the area of a circle
        /// </summary>
        [TestMethod]
        public void CulcArea_Circle_AreaReturned()
        {
            var circle = new Circle(4);

            float expected = 50.26f;
            float actual = AreaCalculate.CulcArea(circle);

            Assert.AreEqual(expected, actual, 0.01);
        }

        /// <summary>
        /// Сalculating the area of a triangle
        /// </summary>
        [TestMethod]
        public void CulcArea_Triangle_AreaReturned()
        {
            var triangle = new Triangle(3, 4, 5);

            float expected = 6f;
            float actual = AreaCalculate.CulcArea(triangle);

            Assert.AreEqual(expected, actual, 0.01);
        }

        /// <summary>
        /// Сalculating the area without figure type using radius
        /// </summary>
        [TestMethod]
        public void CulcArea_Radius_AreaReturned()
        {
            float expected = 50.26f;
            float actual = AreaCalculate.CulcArea(4);

            Assert.AreEqual(expected, actual, 0.01);
        }

        /// <summary>
        /// Сalculating the area without figure type using three sides
        /// </summary>
        [TestMethod]
        public void CulcArea_TriangleSides_AreaReturned()
        {
            float expected = 6f;
            float actual = AreaCalculate.CulcArea(3, 4, 5);

            Assert.AreEqual(expected, actual, 0.01);
        }

    }
}
