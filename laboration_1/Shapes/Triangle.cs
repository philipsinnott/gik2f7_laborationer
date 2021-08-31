using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    public class Triangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public override double CalculateArea() => (Width * Height) / 2;
        public override double CalculateCircumference() => SideA + SideB + SideC;

        public Triangle()
        {
            Width = 10;
            Height = 4;
            SideA = 2.5;
            SideB = 7.25;
            SideC = 3.12;
        }
    }
}
