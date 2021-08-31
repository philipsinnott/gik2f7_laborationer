using System;

namespace Laboration1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Laboration 1 in GIK2F7 | Inheritance & polymorphism");
            Console.WriteLine("Some test examples:\n------------------- ");

            Circle c = new Circle();
            Triangle t = new Triangle();
            Rectangle r = new Rectangle();

            // Set value of properties
            /*
            c.Radius = 3;
            c.Diameter = 5;
            t.Width = 10;
            t.Height = 4;
            t.SideA = 2.5;
            t.SideB = 7.25;
            t.SideC = 3.12;
            r.Width = 3;
            r.Height = 2;
            */

            // Circumference
            Console.WriteLine(c.CalculateCircumference());
            Console.WriteLine(t.CalculateCircumference());
            Console.WriteLine(r.CalculateCircumference());

            // Area
            Console.WriteLine(c.CalculateArea());
            Console.WriteLine(t.CalculateArea());
            Console.WriteLine(r.CalculateArea());

        }
    }
}
