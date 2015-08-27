using System;
using System.Text;

/*
 * Write a method that reverses the digits of given decimal number.
 */
namespace _07.ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumber(num));
        }

        private static int ReverseNumber(int num)
        {
            StringBuilder builder = new StringBuilder();

            int length = num.ToString().Length;

            for (int i = 0; i < length; i++)
            {
                int temp = num % 10;
                builder.Append(temp);
                num /= 10;
            }

            return int.Parse(builder.ToString());
        }
    }
}
