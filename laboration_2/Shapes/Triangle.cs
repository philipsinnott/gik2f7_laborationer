using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    public class Triangle : Shape, IShape
    {
        /// <summary>
        /// Width of the triangle
        /// </summary>
        private double width;
        /// <summary>
        /// Height of the triangle
        /// </summary>
        private double height;
        /// <summary>
        /// Side A of the triangle
        /// </summary>
        private double sideA;
        /// <summary>
        /// Side B of the triangle
        /// </summary>
        private double sideB;
        /// <summary>
        /// Side C of the triangle
        /// </summary>
        private double sideC;


        /// <summary>
        /// Takes 5 doubles, first argument represents the width, second argument represents the height and the remaining three arguments represent the triangles sides.
        /// Sets these values to private variables defined locally
        /// </summary>
        public Triangle(double w, double h, double sideA, double sideB, double sideC)
        {
            this.width = w;
            this.height = h;
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        /// <summary>
        /// Calculates the area of the triangle from width and height specified by user when calling the method
        /// </summary>
        /// <returns>Returns area of triangle</returns>
        public override double CalculateArea() => (width * height) / 2;

        /// <summary>
        /// Calculates the circumference of the triangle from sideA, sideB and sideC specified by user when calling the method
        /// </summary>
        /// <returns>Returns circumference of triangle</returns>
        public override double CalculateCircumference() => sideA + sideB + sideC;

    }
}
