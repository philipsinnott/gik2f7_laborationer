using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double CalculateArea() => Width * Height;
        public override double CalculateCircumference() => 2 * Width + 2 * Height;

        public Rectangle()
        {
            Width = 3;
            Height = 2;
        }

    }
}
