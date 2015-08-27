using System;
using System.Text;

namespace _06.BinaryToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryToHexadecimal("1010111000");
        }

        private static void BinaryToHexadecimal(string binary)
        {
            StringBuilder builder = new StringBuilder(binary);
            StringBuilder hex = new StringBuilder();

            if (builder.Length % 4 != 0)
            {
                builder.Insert(0, "0", 4 - builder.Length % 4);
            }

            string bin = builder.ToString();
            int index = 0;

            for (int i = 0; i < bin.Length / 4; i++)
            {
                switch (bin.Substring(index, 4))
                {
                    case "0000": hex.Append("0"); break;
                    case "0001": hex.Append("1"); break;
                    case "0010": hex.Append("2"); break;
                    case "0011": hex.Append("3"); break;
                    case "0100": hex.Append("4"); break;
                    case "0101": hex.Append("5"); break;
                    case "0110": hex.Append("6"); break;
                    case "0111": hex.Append("7"); break;
                    case "1000": hex.Append("8"); break;
                    case "1001": hex.Append("9"); break;
                    case "1010": hex.Append("A"); break;
                    case "1011": hex.Append("B"); break;
                    case "1100": hex.Append("C"); break;
                    case "1101": hex.Append("D"); break;
                    case "1110": hex.Append("E"); break;
                    case "1111": hex.Append("F"); break;
                }

                index += 4;
            }
            Console.WriteLine(hex);

        }
    }
}
