using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Write a program that finds the biggest of five numbers by using only five if statements.
 */
namespace _06.The_BiggestOfFive
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e;
            double max;

            Console.Write("Enter a:");
            double.TryParse(Console.ReadLine(), out a);

            Console.Write("Enter b:");
            double.TryParse(Console.ReadLine(), out b);

            Console.Write("Enter c:");
            double.TryParse(Console.ReadLine(), out c);

            Console.Write("Enter d:");
            double.TryParse(Console.ReadLine(), out d);

            Console.Write("Enter e:");
            double.TryParse(Console.ReadLine(), out e);

            max = a;

            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            if (d > max)
            {
                max = d;
            }
            if (e > max)
            {
                max = e;
            }

            Console.WriteLine("biggest is " + max);
        }
    }
}
