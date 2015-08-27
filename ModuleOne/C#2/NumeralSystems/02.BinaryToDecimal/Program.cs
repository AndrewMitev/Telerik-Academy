using System;


namespace _02.BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryToDecimal("1010101");
        }

        private static void BinaryToDecimal(string binary)
        {
            int dec = 0, j = 0;

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    dec += (int)Math.Pow(2, j);
                }
                j++;
            }

            Console.WriteLine(dec);
        }
    }
}
