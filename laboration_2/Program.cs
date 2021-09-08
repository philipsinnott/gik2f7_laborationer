using System;

namespace Laboration2
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Laboration 2 in GIK2F7 | Abstraction, encapsulation & interfaces");
            Console.WriteLine("----------------------------------------------------------------\n");

            Shape[] array = new Shape[] { new Circle(2, 5), new Triangle(4.5, 7.5, 2, 5, 7), new Rectangle(3.4, 6) };

            foreach (Shape s in array)
            {
                Console.WriteLine(s.ToString());
            }
            Console.ReadKey();
        }
    }
}
