using System;
using System.Text;

namespace _03.DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            DecimalToHexadecimal(234510);
        }

        private static void DecimalToHexadecimal(int num)
        {
            StringBuilder builder = new StringBuilder();
            StringBuilder reversedBuilder = new StringBuilder();

            while (num != 0)
            {
                if (num % 16 >= 0 && num % 16 <= 9)
                {
                    builder.Append(num % 16);
                }
                else
                {
                    int symbol = num % 16;

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
                num /= 16;
            }

            for (int i = builder.Length - 1, j = 0; i >= 0; i--, j++)
            {
                reversedBuilder.Append(builder[i]);
            }

            Console.WriteLine(reversedBuilder);

        }
    }
}
