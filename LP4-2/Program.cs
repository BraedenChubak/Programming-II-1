﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter weight in kilograms: ");
            int weight = int.Parse(Console.ReadLine());
            Console.Write("Enter length in centimeters: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter width in centimeters: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Enter height in centimeters: ");
            int height = int.Parse(Console.ReadLine());

            int volume = length * width * height;

            if (weight > 27 && volume > 100000)
            {
                Console.WriteLine("Package is too heavy and too large");
            }
            else if (weight > 27)
            {
                Console.WriteLine("Package is too heavy");
            }
            else if (volume > 100000)
            {
                Console.WriteLine("Package is too large");
            }
            else
            {
                Console.WriteLine("Package is okay");
            }
            Console.ReadKey();
        }
    }
}
