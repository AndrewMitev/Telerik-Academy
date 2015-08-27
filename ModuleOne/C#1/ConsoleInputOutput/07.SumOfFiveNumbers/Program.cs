using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum
 */
namespace _07.SumOfFiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            foreach(string num in numbers)
            {
                sum += double.Parse(num);
            }

            Console.WriteLine(sum);
        }
    }
}
