using System;

namespace Laboration2
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Laboration 2 in GIK2F7 | Abstraction, encapsulation & interfaces");
            Console.WriteLine("----------------------------------------------------------------\n");

            Circle c = new(2, 5);
            Triangle t = new(4.5, 7.5, 2, 5, 7);
            Rectangle r = new(3.4, 6);

            Console.WriteLine(c.ToString());
            Console.WriteLine(t.ToString());
            Console.WriteLine(r.ToString());

            Console.ReadKey();
        }
    }
}
