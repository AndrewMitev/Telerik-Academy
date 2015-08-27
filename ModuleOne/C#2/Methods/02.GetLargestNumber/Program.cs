using System;

/*
 * 
 * Write a method GetMax() with two parameters that returns the larger of two integers.
 * Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax()
 */
namespace _02.GetLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a:");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter b:");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter c:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(c, GetMax(a, b)));
        }

        private static int GetMax(int x, int y)
        {
            return x > y ? x : y;
        }
    }
}
