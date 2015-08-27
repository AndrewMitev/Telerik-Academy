using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Write a program that finds the biggest of three numbers.
 */
namespace _05.BiggestOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double max;

            Console.Write("Enter a:");
            double.TryParse(Console.ReadLine(), out a);

            Console.Write("Enter b:");
            double.TryParse(Console.ReadLine(), out b);

            Console.Write("Enter c:");
            double.TryParse(Console.ReadLine(), out c);

            max = a;

            if(b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            Console.WriteLine("biggest is " + max);
        }
    }
}
