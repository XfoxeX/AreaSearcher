using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaSearcher.Figures;
using System;

namespace AreaSearcher.Figures.Tests
{
    [TestClass()]
    public class CircleTests
    {
        /// <summary>
        /// Class initialization with radius < 0
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateCircle_NegativeParam_ExceptionReturned()
        {
            var circle = new Circle(-1);
        }
        
        /// <summary>
        /// Class initialization with radius == 0
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateCircle_ZeroParam_ExceptionReturned()
        {
            var circle = new Circle(0);
        }

        /// <summary>
        /// Class initialization with radius > 0
        /// </summary>
        [TestMethod()]
        public void CircleTest()
        {
            var circle = new Circle(4);
        }

    }
}