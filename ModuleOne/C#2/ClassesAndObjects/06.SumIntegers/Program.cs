using System;

/*
 * @Task
 * You are given a sequence of positive integer values written into a string, separated by spaces.
 * Write a function that reads these values from given string and calculates their sum.
 */
namespace _06.SumIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "43 68 9 23 318";
            int sum = 0;

            string[] numbers = input.Split(' ');

            foreach (string num in numbers)
            {
                sum += int.Parse(num);
            }

            Console.WriteLine(sum);
        }
    }
}
