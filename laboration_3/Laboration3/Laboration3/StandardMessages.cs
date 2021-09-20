using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public class StandardMessages
    {
        public static void DisplayStartupText()
        {
            Console.WriteLine($"  Assignment 3 in GIK2F7 | Philip Sinnott & Mattias Hedlund");
        }
        public static void DisplayExitProgram()
        {
            Console.WriteLine($"Exited the application...");
        }
        public static void DisplayHrLine()
        {
            Console.WriteLine("=============================================================");
        }
    }
}
