using System;

namespace Laboration1
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Laboration 1 in GIK2F7 | Inheritance & polymorphism");
            Console.WriteLine("Some test examples:\n------------------- ");

            Circle c = new Circle();
            Triangle t = new Triangle();
            Rectangle r = new Rectangle();

            // Circumference
            Console.WriteLine(c.CalculateCircumference(5));
            Console.WriteLine(t.CalculateCircumference(5, 7.3, 2));
            Console.WriteLine(r.CalculateCircumference(7.23, 4));

            // Area
            Console.WriteLine(c.CalculateArea(3));
            Console.WriteLine(t.CalculateArea(27, 3.4));
            Console.WriteLine(r.CalculateArea(5, 2.5));

        }
    }
}
