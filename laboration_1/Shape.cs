using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    public class Shape
    {
        public double CalculateArea(double width, double height) => width * height;

        // Omkrets = Circumference | Perimeter
        public double CalculateCircumference(double width, double height) => width + width + height + height;

    }
}
