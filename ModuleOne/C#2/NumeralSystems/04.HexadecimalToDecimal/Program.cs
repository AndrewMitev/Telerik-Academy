using System;


namespace _04.HexadecimalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            HexadecimalToDecimal("F2E");
        }

        private static void HexadecimalToDecimal(string hex)
        {
            int num = 0;

            for (int i = hex.Length - 1, j = 0; i >= 0; i--, j++)
            {
                if (char.IsDigit(hex[i]))
                {
                    num += int.Parse(hex[i].ToString()) * (int)Math.Pow(16, j);
                }
                else
                {
                    int multiply;

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

                    num += multiply * (int)Math.Pow(16, j);
                }
            }
            Console.WriteLine(num);
        }
    }
}
