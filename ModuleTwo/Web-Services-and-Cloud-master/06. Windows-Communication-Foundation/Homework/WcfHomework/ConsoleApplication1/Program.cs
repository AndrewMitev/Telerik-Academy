using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "nana";
            string str2 = "na";
            int counter = 0;
            int pos = 0;
            int lengthOfWord = str2.Length;

            while (true)
            {
                pos = str1.IndexOf(str2, pos);

                if (pos < 0)
                {
                    break;
                }

                pos += lengthOfWord;

                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
