namespace EnigmaCat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<StringBuilder> list = new List<StringBuilder>();

            for (int i = 0; i < input.Length; i++)
            {
                BigInteger num = ConvertToDecimal(input[i]);

                list.Add(DecodeNumbersToMessage(num));
            }

            string output = string.Join(" ", list);
            Console.WriteLine(output);
        }

        private static BigInteger ConvertToDecimal(string word)
        {
            BigInteger sum = new BigInteger(0);

            for (int i = word.Length - 1, j = 0; i >= 0; i--, j++)
            {
                long digit = 0;
                char symbol = word[i];

                switch (symbol)
                {
                    case 'a':
                        {
                            digit = 0;
                            break;
                        }

                    case 'b':
                        {
                            digit = 1;
                            break;
                        }

                    case 'c':
                        {
                            digit = 2;
                            break;
                        }

                    case 'd':
                        {
                            digit = 3;
                            break;
                        }

                    case 'e':
                        {
                            digit = 4;
                            break;
                        }

                    case 'f':
                        {
                            digit = 5;
                            break;
                        }

                    case 'g':
                        {
                            digit = 6;
                            break;
                        }

                    case 'h':
                        {
                            digit = 7;
                            break;
                        }

                    case 'i':
                        {
                            digit = 8;
                            break;
                        }

                    case 'j':
                        {
                            digit = 9;
                            break;
                        }

                    case 'k':
                        {
                            digit = 10;
                            break;
                        }

                    case 'l':
                        {
                            digit = 11;
                            break;
                        }

                    case 'm':
                        {
                            digit = 12;
                            break;
                        }

                    case 'n':
                        {
                            digit = 13;
                            break;
                        }

                    case 'o':
                        {
                            digit = 14;
                            break;
                        }

                    case 'p':
                        {
                            digit = 15;
                            break;
                        }

                    case 'q':
                        {
                            digit = 16;
                            break;
                        }

                    case 'r':
                        {
                            digit = 17;
                            break;
                        }

                    case 's':
                        {
                            digit = 18;
                            break;
                        }

                    case 't':
                        {
                            digit = 19;
                            break;
                        }

                    case 'u':
                        {
                            digit = 20;
                            break;
                        }

                    default: throw new ArgumentException("ConvertTodecimal(): Invalid character symbol in word!");
                }

                sum += digit * PowSeventeen(j);
            }

            return sum;
        }

        private static BigInteger PowSeventeen(int j)
        {
            if (j <= 0)
            {
                throw new ArgumentException("PowSeventeen(): must pass positive number");
            }

            BigInteger result = 1;

            for (int i = 1; i <= j; i++)
            {
                result *= 17;
            }

            return result;
        }

        private static StringBuilder DecodeNumbersToMessage(BigInteger number)
        {
            StringBuilder builder = new StringBuilder();

            List<long> list = new List<long>();

            DivideListMembersByTwentySix(number, list);

            for (int i = list.Count - 1; i >= 0; i--)
            {
                char symbol;

                switch (list[i])
                {
                    case 0:
                        {
                            symbol = 'a';
                            break;
                        }

                    case 1:
                        {
                            symbol = 'b';
                            break;
                        }

                    case 2:
                        {
                            symbol = 'c';
                            break;
                        }

                    case 3:
                        {
                            symbol = 'd';
                            break;
                        }

                    case 4:
                        {
                            symbol = 'e';
                            break;
                        }

                    case 5:
                        {
                            symbol = 'f';
                            break;
                        }

                    case 6:
                        {
                            symbol = 'g';
                            break;
                        }

                    case 7:
                        {
                            symbol = 'h';
                            break;
                        }

                    case 8:
                        {
                            symbol = 'i';
                            break;
                        }

                    case 9:
                        {
                            symbol = 'j';
                            break;
                        }

                    case 10:
                        {
                            symbol = 'k';
                            break;
                        }

                    case 11:
                        {
                            symbol = 'l';
                            break;
                        }

                    case 12:
                        {
                            symbol = 'm';
                            break;
                        }

                    case 13:
                        {
                            symbol = 'n';
                            break;
                        }

                    case 14:
                        {
                            symbol = 'o';
                            break;
                        }

                    case 15:
                        {
                            symbol = 'p';
                            break;
                        }

                    case 16:
                        {
                            symbol = 'q';
                            break;
                        }

                    case 17:
                        {
                            symbol = 'r';
                            break;
                        }

                    case 18:
                        {
                            symbol = 's';
                            break;
                        }

                    case 19:
                        {
                            symbol = 't';
                            break;
                        }

                    case 20:
                        {
                            symbol = 'u';
                            break;
                        }

                    case 21:
                        {
                            symbol = 'v';
                            break;
                        }

                    case 22:
                        {
                            symbol = 'w';
                            break;
                        }

                    case 23:
                        {
                            symbol = 'x';
                            break;
                        }

                    case 24:
                        {
                            symbol = 'y';
                            break;
                        }

                    case 25:
                        {
                            symbol = 'z';
                            break;
                        }

                    default:
                        {
                            symbol = ' ';
                            break;
                        }
                }

                builder.Append(symbol);
            }

            return builder;
        }

        private static void DivideListMembersByTwentySix(BigInteger number, List<long> list)
        {
            while (number != 0)
            {
                if (number != 0)
                {
                    list.Add((long)number % 26);
                }

                number /= 26;
            }
        }
    }
}
