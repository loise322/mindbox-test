using FigureAreaLibrary.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FigureAreaLibrary.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateParams_RadiusValue_ThrowArgumentException()
        {
            Circle circle = new Circle(-1);
        }

        [TestMethod]
        public void GetArea_Area_CorrectValue()
        {
            Circle circle = new Circle(5);

            double area = circle.GetArea();

            Assert.AreEqual(78.53981633974483, area);
        }
    }
}