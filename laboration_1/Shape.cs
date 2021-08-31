using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    public class Shape
    {
        public virtual double CalculateArea() => 0;

        // Omkrets = Circumference | Perimeter
        public virtual double CalculateCircumference() => 0;

    }
}
