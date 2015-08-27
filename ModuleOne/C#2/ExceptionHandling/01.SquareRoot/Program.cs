using System;

/*
 * @ Task
 * Write a program that reads an integer number and calculates and prints its square root.
 * If the number is invalid or negative, print Invalid number.
 * In all cases finally print Good bye.
 * Use try-catch-finally block.
 */
namespace _01.SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter number: ");

            try
            {
                n = int.Parse(Console.ReadLine());

                if (n<0)
                {
                    throw new Exception("Invalid exception");
                }

                Console.WriteLine(Math.Sqrt(n));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid argument");
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }

        }
    }
}
