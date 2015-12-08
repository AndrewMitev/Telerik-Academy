using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromize
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            StringBuilder wordBuilder = new StringBuilder(word);

            for (int i = 0; i <= word.Length - 1; i++)
            {
                var toAdd = word.Substring(0, i).ToCharArray();
                Array.Reverse(toAdd);

                string answer = word + new string(toAdd);

                if (IsPal(answer))
                {
                    Console.WriteLine(answer);
                    break;
                }
            }
        }

        private static bool IsPal(string str)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                builder.Append(str[i]);
            }

            return str.Equals(builder.ToString()) ? true : false;
        }
    }
}
