using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    public class Triangle : Shape
    {
        public double CalculateArea(double width, double height) => (width * height) / 2;
        public double CalculateCircumference(double sideA, double sideB, double sideC) => sideA + sideB + sideC;
    }
}
