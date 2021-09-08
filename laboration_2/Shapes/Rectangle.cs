using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    public class Rectangle : Shape, IShape
    {
        /// <summary>
        /// Width of the rectangle
        /// </summary>
        private double width;
        /// <summary>
        /// Height of the rectangle
        /// </summary>
        private double height;

        /// <summary>
        /// Takes 2 doubles, first argument represents the width and the other argument represents the height
        /// Sets these values to private variables defined locally
        /// </summary>
        public Rectangle(double w, double h)
        {
            this.width = w;
            this.height = h;
        }

        /// <summary>
        /// Calculates the area of the rectangle from width and height specified by user when calling the method
        /// </summary>
        /// <returns>Returns area of rectangle</returns>
        public override double CalculateArea() => width * height;

        /// <summary>
        /// Calculates the circumference of the rectangle from width and height specified by user when calling the method
        /// </summary>
        /// <returns>Returns circumference of rectangle</returns>
        public override double CalculateCircumference() => 2 * width + 2 * height;

    }
}
