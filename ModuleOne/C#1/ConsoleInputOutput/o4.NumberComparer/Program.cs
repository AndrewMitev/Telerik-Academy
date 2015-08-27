using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Write a program that gets two numbers from the console and prints the greater of them.
 * Try to implement this without if statements
 */
namespace o4.NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter two numbers:");
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("Greater number is {0}", ((a > b) ? a : b));
        }
    }
}
