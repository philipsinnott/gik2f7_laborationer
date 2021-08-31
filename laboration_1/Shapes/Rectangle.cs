using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    public class Rectangle : Shape
    {
        public double CalculateArea(double width, double height) => width * height;
        public double CalculateCircumference(double width, double height) => 2 * width + 2 * height;
    }
}
