using System;
using System.Text;
/*
 * @Task
 * Write a program that encodes and decodes a string using given encryption key (cipher).
 */
namespace _07.EncodeDecode
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();

            string message = "Hello, this world is beautiful.";
            string cipher = "cipher";
            int j = 0;

            for (int i = 0; i < message.Length; i++)
            {
                char symbol = (char)(message[i] ^ cipher[j]);
                builder.Append(symbol);

                if (j == cipher.Length)
                {
                    j = 0;
                }
            }

            string enc = builder.ToString();

            StringBuilder b = new StringBuilder();

            Console.WriteLine("Encoded message: \n" + enc);
            j = 0;

            for (int i = 0; i < enc.Length; i++)
            {
                char decodedSymbol = (char)(enc[i] ^ cipher[j]);
                b.Append(decodedSymbol);

                if (j == cipher.Length)
                {
                    j = 0;
                }
            }

            Console.WriteLine("Decoding .. \n" + b);
        }
    }
}
