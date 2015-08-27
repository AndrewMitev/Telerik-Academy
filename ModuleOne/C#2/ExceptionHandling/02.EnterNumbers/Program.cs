using System;

/*
 * @ Task
 * Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
 * If an invalid number or non-number text is entered, the method should throw an exception.
 * Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */
namespace _02.EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter number: ");
                n = ReadNumber(n, 100);
            }
        }

        private static int ReadNumber(int start, int end)
        {
            int n = -1;

            try
            {
                n = int.Parse(Console.ReadLine());

                if (n < start || n > end)
                {
                    throw new Exception("Not in the required interval, beyotch!");
                }
            }
            catch (FormatException f)
            {
                Console.WriteLine(f.Message);
            }

            return n;
        }
    }
}
