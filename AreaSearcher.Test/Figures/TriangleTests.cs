using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaSearcher.Figures;
using System;

namespace AreaSearcher.Figures.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        /// <summary>
        /// Class initialization with side <= 0
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateTriangle_NegativeZeroParam_ExceptionReturned()
        {
            var triangle1 = new Triangle(-1, 4, 5);
            var triangle2 = new Triangle(0, 4, 5);
        }

        /// <summary>
        /// Class initialization with 1 side >= 2 + 3 sides
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateTriangle_FirstSide_ExceptionReturned()
        {
            var triangle = new Triangle(2, 1, 1);
        }

        /// <summary>
        /// Class initialization with 2 side >= 1 + 3 sides
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateTriangle_SecondSide_ExceptionReturned()
        {
            var triangle = new Triangle(1, 2, 1);
        }

        /// <summary>
        /// Class initialization with 3 side >= 2 + 1 sides
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateTriangle_ThirdSide_ExceptionReturned()
        {
            var triangle = new Triangle(1, 1, 2);
        }

        /// <summary>
        /// Checking a triangle for a right triangle
        /// </summary>
        [TestMethod()]
        public void IsRightTriangle_NotRight_FalseReturned()
        {
            var triangle = new Triangle(2f, 2f, 2f);

            bool expected = false;
            bool actual = triangle.IsRightTriangle();

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Checking a triangle for a right triangle
        /// </summary>
        [TestMethod()]
        public void IsRightTriangle_Right_TrueReturned()
        {
            var triangle = new Triangle(3f, 4f, 5f);

            bool expected = true;
            bool actual = triangle.IsRightTriangle();

            Assert.AreEqual(expected, actual);
        }

    }
}