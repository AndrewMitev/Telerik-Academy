using System;
using System.Text;


namespace _01.DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            DecimalToBinary(30);
        }

        private static void DecimalToBinary(int num)
        {
            StringBuilder binary = new StringBuilder();

            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    binary.Append(0);
                }
                else
                {
                    binary.Append(1);
                }

                num /= 2;
            }

            Console.WriteLine(binary);
        }
    }
}
