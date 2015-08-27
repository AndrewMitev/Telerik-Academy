using System;
using System.Text;

namespace _05.HexadecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            HexadecimalToBinary("2FE");
        }

        private static void HexadecimalToBinary(string hexa)
        {
            StringBuilder builder = new StringBuilder();
            string binary;

            for (int i = 0; i < hexa.Length; i++)
            {
                switch (hexa[i])
                {
                    case '0': builder.Append("0000"); break;
                    case '1': builder.Append("0001"); break;
                    case '2': builder.Append("0010"); break;
                    case '3': builder.Append("0011"); break;
                    case '4': builder.Append("0100"); break;
                    case '5': builder.Append("0101"); break;
                    case '6': builder.Append("0110"); break;
                    case '7': builder.Append("0111"); break;
                    case '8': builder.Append("1000"); break;
                    case '9': builder.Append("1001"); break;
                    case 'A': builder.Append("1010"); break;
                    case 'B': builder.Append("1011"); break;
                    case 'C': builder.Append("1100"); break;
                    case 'D': builder.Append("1101"); break;
                    case 'E': builder.Append("1110"); break;
                    case 'F': builder.Append("1111"); break;
                }
            }
            Console.WriteLine(builder);
        }
    }
}
