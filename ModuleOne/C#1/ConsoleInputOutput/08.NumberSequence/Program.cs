using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], 
 * each on a single line.
 */
namespace _08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Enter n:");
            int.TryParse(Console.ReadLine(), out n);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
