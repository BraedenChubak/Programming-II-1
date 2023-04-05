using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang54cConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            Console.Write("Enter Radius: ");
            int rad = int.Parse(Console.ReadLine());
            double circum = 2 * pi * rad;
            double area = pi * rad * rad;
            Console.WriteLine("Circumference: " + Math.Round(circum, 3));
            Console.WriteLine("Area: " + Math.Round(area, 3));
            Console.ReadKey();

        }
    }
}
