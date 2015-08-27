using System;
using System.Text;

namespace _08.BinaryShort
{
    class Program
    {
        static void Main()
        {
            Console.Write("enter short: ");
            short num = short.Parse(Console.ReadLine());

            Console.WriteLine(toBinary(num));
        }

        private static string toBinary(short num)
        {
            StringBuilder builder = new StringBuilder();

            while (num != 0 && num != -1)
            {
                builder.Insert(0, (num % 2) & 1);

                num >>= 1;
                Console.WriteLine(num);
            }


            return builder.ToString().PadLeft(17 - builder.Length, '0');
        }
    }
}
