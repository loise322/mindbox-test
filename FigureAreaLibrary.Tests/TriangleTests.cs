using FigureAreaLibrary.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FigureAreaLibrary.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateParams_SideA_ThrowArgumentException()
        {
            Triangle triangle = new Triangle(-1, 5, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateParams_SideB_ThrowArgumentException()
        {
            Triangle triangle = new Triangle(5, -1, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateParams_SideC_ThrowArgumentException()
        {
            Triangle triangle = new Triangle(5, 5, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateParams_SumSideAAndSideBLesserSideC_ThrowArgumentException()
        {
            Triangle triangle = new Triangle(2, 5, 9);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateParams_SumSideAAndSideBEqualSideC_ThrowArgumentException()
        {
            Triangle triangle = new Triangle(4, 5, 9);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateParams_SumSideAAndSideCLesserSideB_ThrowArgumentException()
        {
            Triangle triangle = new Triangle(3, 9, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateParams_SumSideAAndSideCEqualSideB_ThrowArgumentException()
        {
            Triangle triangle = new Triangle(4, 9, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateParams_SumSideBAndSideCLesserSideA_ThrowArgumentException()
        {
            Triangle triangle = new Triangle(9, 2, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateParams_SumSideBAndSideCEqualSideA_ThrowArgumentException()
        {
            Triangle triangle = new Triangle(9, 4, 5);
        }

        [TestMethod]
        public void IsRightTriangle_RightTriangle_True()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Assert.IsTrue(triangle.IsRightTriangle);
        }

        [TestMethod]
        public void IsRightTriangle_NotRightTriangle_False()
        {
            Triangle triangle = new Triangle(3, 5, 7);

            Assert.IsFalse(triangle.IsRightTriangle);
        }

        [TestMethod]
        public void GetArea_Area_CorrectValue()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            double area = triangle.GetArea();

            Assert.AreEqual(6, area);
        }
    }
}
