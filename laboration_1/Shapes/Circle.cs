using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    public class Circle : Shape
    {
        public double CalculateArea(double radius) => Math.PI * Math.Pow(radius, 2);

        public double CalculateCircumference(double diameter) => Math.PI * diameter;
    }
}
