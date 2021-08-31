using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public double Diameter { get; set; }
        public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
        public override double CalculateCircumference() => Math.PI * Diameter;

        public Circle()
        {
            Radius = 3;
            Diameter = 5;
        }
    }

}
