using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLibrary.Figures
{
    /// <summary>
    /// Circle
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// Radius
        /// </summary>
        public double Radius { get; }

        public Circle(double radius)
        {
            ValidateParams(radius);

            Radius = radius;
        }

        /// <summary>
        /// Calculation the area of a circle
        /// </summary>
        /// <returns>Value of area</returns>
        public double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        internal void ValidateParams(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius cannot be lesser or equal Zero");
            } 
        }
    }
}
