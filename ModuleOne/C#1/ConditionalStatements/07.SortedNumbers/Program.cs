using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that enters 3 real numbers and prints them sorted in descending order.
 * Use nested if statements.
 */
namespace _07.SortedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.Write("Enter a:");
            double.TryParse(Console.ReadLine(), out a);

            Console.Write("Enter b:");
            double.TryParse(Console.ReadLine(), out b);

            Console.Write("Enter c:");
            double.TryParse(Console.ReadLine(), out c);

            if (a > b && a > c)
            {
                Console.Write(a);

                if (b > c)
                {
                    Console.Write(" " + b + " " + c);
                }
                else
                {
                    Console.Write(" " + c + " " + b);
                }
            }

            if (b > a && b > c)
            {
                Console.Write(b);

                if (a > c)
                {
                    Console.Write(" " + a + " " + c);
                }
                else
                {
                    Console.Write(" " + c + " " + a);
                }
            }

            if (c > a && c > b)
            {
                Console.Write(c);

                if (a > b)
                {
                    Console.Write(" " + a + " " + b);
                }
                else
                {
                    Console.Write(" " + b + " " + a);
                }
            }
            Console.WriteLine();
        }
    }
}
