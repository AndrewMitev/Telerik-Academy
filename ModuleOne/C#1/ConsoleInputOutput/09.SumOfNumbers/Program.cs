using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that enters a number n and after that enters more
 * n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
 */
namespace _09.SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, sum = 0;
            Console.WriteLine("How many numbers?");

            double.TryParse(Console.ReadLine(), out n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter number:");
                sum += double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Their sum is " + sum);
        }
    }
}
