using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Write a program that reads the coefficients a, b and c of 
 * a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 */
namespace _06.QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, D;

            Console.Write("Enter a:");
            double.TryParse(Console.ReadLine(), out a);

            Console.Write("Enter b:");
            double.TryParse(Console.ReadLine(), out b);

            Console.Write("Enter c:");
            double.TryParse(Console.ReadLine(), out c);

            D = Math.Pow(b, 2) - (4 * a * c);

            if (D < 0)
            {
                Console.WriteLine("no real roots");
                Environment.Exit(0);
            }

            x2 = (-b + Math.Sqrt(D)) / (2 * a);
            x1 = (-b - Math.Sqrt(D)) / (2 * a);

            Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
        }
    }
}
