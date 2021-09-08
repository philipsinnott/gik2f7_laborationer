using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    public abstract class Shape
    {
        /// <summary>
        /// Base method for calculating the area of a shape
        /// </summary>
        /// <returns>Returns a double representing the area of a shape</returns>
        public virtual double CalculateArea() => 0;
        /// <summary>
        /// Base method for calculating the circumference of a shape
        /// </summary>
        /// <returns>Returns a double representing the circumference of a shape</returns>
        public virtual double CalculateCircumference() => 0;
        /// <summary>
        /// Prints name of class (specific shape) with its corresponding area and circumference
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string ToString() => $"{this.GetType().Name.ToUpper()}:\n-----------------\nArea: {CalculateArea()} | Circumference: {CalculateCircumference()}\n";
    }

    interface IShape
    {
        double CalculateArea();
        double CalculateCircumference();
    }
}
