using System;

/*
 * Write a method that returns the last digit of given integer as an English word.
 */
namespace _03.EnglishDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer:");
            int num = int.Parse(Console.ReadLine());

            int digit = num % 10;

            SayDigit(digit);
        }

        private static void SayDigit(int digit)
        {
            switch (digit)
            {
                case 0: Console.WriteLine("Zero"); break;
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                default: break;
            }
        }
    }
}
