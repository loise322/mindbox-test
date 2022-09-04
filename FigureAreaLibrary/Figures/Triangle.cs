using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLibrary.Figures
{
    /// <summary>
    /// Triangle
    /// </summary>
    public class Triangle : IFigure
    {
        /// <summary>
        /// Side A
        /// </summary>
        public double SideA { get; }
        /// <summary>
        /// Side B
        /// </summary>
        public double SideB { get; }
        /// <summary>
        /// Side C
        /// </summary>
        public double SideC { get; }
        /// <summary>
        /// Flag of rightness triangle
        /// </summary>
        public bool IsRightTriangle { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            ValidateParams(sideA, sideB, sideC);

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            IsRightTriangle = GetIsRightTriangle();
        }

        /// <summary>
        /// Calculating the area of a triangle
        /// </summary>
        /// <returns>Value of area</returns>
        public double GetArea()
        {
            double halfPerimeter = (SideA + SideB + SideC) / 2d;

            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - SideA)
                                                  * (halfPerimeter - SideB)
                                                  * (halfPerimeter - SideC)
                                   );

            return area;
        }

        internal void ValidateParams(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0)
            {
                throw new ArgumentException($"Side {nameof(sideA)}: {sideA} cannot be lesser or equal Zero");
            }
            if (sideA <= 0)
            {
                throw new ArgumentException($"Side {nameof(sideB)}: {sideB} cannot be lesser or equal Zero");
            }
            if (sideA <= 0)
            {
                throw new ArgumentException($"Side {nameof(sideC)}: {sideC} cannot be lesser or equal Zero");
            }

            if (sideA + sideB <= sideC)
            {
                throw new ArgumentException($"The sum of the sides ({nameof(sideA)}: {sideA}, {nameof(sideB)}: {sideB}) cannot be lesser or equal than the third side ({nameof(sideC)}: {sideC})!");
            }

            if (sideA + sideC <= sideB)
            {
                throw new ArgumentException($"The sum of the sides ({nameof(sideA)}: {sideA}, {nameof(sideC)}: {sideC}) cannot be lesser or equal than the third side ({nameof(sideB)}: {sideB})!");
            }

            if (sideB + sideC <= sideA)
            {
                throw new ArgumentException($"The sum of the sides ({nameof(sideB)}: {sideB}, {nameof(sideC)}: {sideC}) cannot be lesser or equal than the third side ({nameof(sideA)}: {sideA})!");
            }
        }

        internal bool GetIsRightTriangle()
        {
            return Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2);
        }
    }
}
