using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Security.Authentication.ExtendedProtection;

namespace TriangleExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the length of side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of side c: ");
            double c = double.Parse(Console.ReadLine());
            double circuit = Math.Round(a + b + c);
            double area = Math.Sqrt(circuit / 2 * (circuit / 2 - a) * (circuit / 2 - b) * (circuit / 2 - c));
            double pythagoras = Math.Pow(a, 2) + Math.Pow(b, 2);


            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Incorrect date. Side lengths must be plus!");
                return;
            }

            if (a + b < c)
            {
                Console.WriteLine("Incorrect data. The triangle cannot be built!");
                return;
            }

            else if (circuit > 0)
            {
                Console.WriteLine("circuit = {0:N2}", circuit);
            }

            if (area > 0)
            {
                Console.WriteLine("area = {0:N2}", area);
            }

            if (pythagoras == Math.Pow(c, 2))
            {
                Console.WriteLine("The triangle is rectangular");
                return;
            }

            if (pythagoras < Math.Pow(c, 2))
            {
                Console.WriteLine("The triangle is obtuse");
            }


            if (pythagoras > Math.Pow(c, 2))
            {
                Console.WriteLine("The triangle is acute");
            }


            if (a == b || a == c || b == c)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Equilateral triangle");
                }
                else
                    Console.WriteLine("Isosceles triangle");
            }

            Console.ReadKey();





        }
    }
}