using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    public class Circle : Shape, IShape
    {
        /// <summary>
        /// Radius of the circle
        /// </summary>
        private double radius;
        /// <summary>
        /// Diameter
        /// </summary>
        private double diameter;

        /// <summary>
        /// Takes 2 doubles, first argument represents the radius and the other argument represents the diameter
        /// Sets these values to private variables defined locally
        /// </summary>
        public Circle(double r, double d)
        {
            this.radius = r;
            this.diameter = d;
        }

        /// <summary>
        /// Calculates the area of the circle from radius specified by user when calling the method
        /// </summary>
        /// <returns>Returns area of circle</returns>
        public override double CalculateArea() => Math.PI * Math.Pow(radius, 2);

        /// <summary>
        /// Calculates the circumference of the circle from diameter specified by user when calling the method
        /// </summary>
        /// <returns>Returns circumference of circle</returns>
        public override double CalculateCircumference() => Math.PI * diameter;
    }

}
