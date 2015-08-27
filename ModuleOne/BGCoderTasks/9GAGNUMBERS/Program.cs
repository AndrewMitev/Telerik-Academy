using System;
using System.Collections.Generic;
using System.Text;

namespace _9GAGNUMBERS
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder builder = new StringBuilder();
            List<int> list = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                builder.Append(input[i]);

                if (CheckInTable(builder.ToString()) != -1)
                {
                    list.Add(CheckInTable(builder.ToString()));
                    builder.Clear();
                }
            }

            int result = 0;

            for (int i = list.Count - 1, j = 0; i >= 0; i--, j++)
            {
                result += list[i] * (int)Math.Pow(9, j);
            }

            Console.WriteLine(result);
        }

        private static int CheckInTable(string symbol)
        {
            int value = -1;

            switch (symbol)
            {
                case "-!": value =  0; break;
                case "**": value =  1; break;
                case "!!!":value =  2; break;
                case "&&": value =  3; break;
                case "&-": value =  4; break;
                case "!-": value =  5; break;
                case "*!!!": value =  6; break;
                case "&*!": value =  7; break;
                case "!!**!-": value =  8; break;
                default: break;
            }

            return value;
        }
    }
}
