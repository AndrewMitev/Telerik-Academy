using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeAndDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            string encrypted = Console.ReadLine();
            int lengthOfCypher = 0;

            StringBuilder builder = new StringBuilder();

            for (int i = encrypted.Length - 1; i >= 0; i--)
            {

                if (Char.IsDigit(encrypted[i]))
                {
                    builder.Insert(0, encrypted[i]);
                }
                else
                {
                    break;
                }

            }

            if (builder.Length == 0)
            {
                lengthOfCypher = 0;
            }
            else
            {
                lengthOfCypher = int.Parse(builder.ToString());
            }
            encrypted = encrypted.Replace(builder.ToString(), "");
            
            string decoded = Decode(encrypted);

            string cypher = decoded.Substring(decoded.Length - lengthOfCypher);

            string messageToDecrypt = decoded.Remove(decoded.Length - lengthOfCypher);


            Console.WriteLine(Encrypt(messageToDecrypt, cypher));

        }

        private static string Decode(string text)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (!Char.IsDigit(text[i]) || text[i] == '2')
                {
                    builder.Append(text[i]);
                }
                else if (i != text.Length - 1)
                {
                    builder.Append(text[i + 1], int.Parse(text[i++].ToString()));
                }
            }

            return builder.ToString();
        }

        private static string Encrypt(string message, string cypher)
        {
            StringBuilder builder = new StringBuilder(message);

            int steps = Math.Max(message.Length, cypher.Length);

            for (int i = 0; i < steps; i++)
            {
                int messageIndex = i % message.Length;
                int cypherIndex = i % cypher.Length;

                builder[messageIndex] = (char)( ((builder[messageIndex] - 'A') ^ (cypher[cypherIndex] - 'A')) + 'A');
            }

            return builder.ToString();
        }
    }
}
