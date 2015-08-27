using System;
using System.Text;

/*
 * @Task
 * Write a program to convert from any numeral system of given base s
 * to any other numeral system of base d (2 ≤ s, d ≤ 16).
 */
namespace _07.OneSystemToAnyOther
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Base (s >= 2)");
            byte s = byte.Parse(Console.ReadLine());

            if (s < 2 || s > 16)
            {
                Console.WriteLine("Error");
                Environment.Exit(0);
            }

            Console.WriteLine("Enter d (d <= 16)");
            byte d = byte.Parse(Console.ReadLine());

            if (d < 2 || d > 16)
            {
                Console.WriteLine("Error");
                Environment.Exit(0);
            }

            Console.Write("Enter number: ");
            string num = Console.ReadLine();

            ValidateInput(num, s);

            Console.WriteLine(DecimalToBigger(BiggerToDecimal(num, s), d));

        }

        private static long BiggerToDecimal(string hex, int Base)
        {
            long num = 0;

            for (int i = hex.Length - 1, j = 0; i >= 0; i--, j++)
            {
                if (char.IsDigit(hex[i]))
                {
                    num += long.Parse(hex[i].ToString()) * (long)Math.Pow(Base, j);
                }
                else
                {
                    long multiply;

                    switch (hex[i])
                    {
                        case 'A': multiply = 10; break;
                        case 'B': multiply = 11; break;
                        case 'C': multiply = 12; break;
                        case 'D': multiply = 13; break;
                        case 'E': multiply = 14; break;
                        case 'F': multiply = 15; break;
                        default: multiply = 1; break;
                    }

                    num += multiply * (long)Math.Pow(Base, j);
                }
            }
            return num;
        }

        private static string DecimalToBigger(long num, int Base)
        {
            StringBuilder builder = new StringBuilder();
            StringBuilder reversedBuilder = new StringBuilder();

            while (num != 0)
            {
                if (num % Base >= 0 && num % Base <= 9)
                {
                    builder.Append(num % Base);
                }
                else
                {
                    long symbol = num % Base;

                    switch (symbol)
                    {
                        case 10: builder.Append("A"); break;
                        case 11: builder.Append("B"); break;
                        case 12: builder.Append("C"); break;
                        case 13: builder.Append("D"); break;
                        case 14: builder.Append("E"); break;
                        case 15: builder.Append("F"); break;
                    }
                }
                num /= Base;
            }

            for (int i = builder.Length - 1, j = 0; i >= 0; i--, j++)
            {
                reversedBuilder.Append(builder[i]);
            }

            return reversedBuilder.ToString();
        }

        private static void ValidateInput(string num, byte Base)
        {
            
            for (int i = 0; i < num.Length; i++)
            {
                sbyte symbol;

                if (char.IsDigit(num[i]))
                {
                    symbol = Convert.ToSByte(num[i].ToString());
                }
                else
                {
                    char c = num[i];
                    c = Char.ToUpper(c);
                    switch (c)
                    {
                        case 'A': symbol = 10; break;
                        case 'B': symbol = 11; break;
                        case 'C': symbol = 12; break;
                        case 'D': symbol = 13; break;
                        case 'E': symbol = 14; break;
                        case 'F': symbol = 15; break;
                        default: symbol = -1; break;
                    }
                }

                if (symbol > Base || symbol == -1)
                {
                    Console.WriteLine("Invalid input");
                    Environment.Exit(0);
                }
            }
        }
    }
}
