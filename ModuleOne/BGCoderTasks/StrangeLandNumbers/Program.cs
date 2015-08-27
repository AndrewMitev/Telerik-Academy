using System;
using System.Text;
using System.Collections.Generic;

namespace StrangeLandNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> list = new List<int>();
            StringBuilder builder = new StringBuilder();
            

            for (int i = 0; i < input.Length; i++)
            {
                builder.Append(input[i]);

                if (Check(builder.ToString()) != -1)
                {
                    list.Add(Check(builder.ToString()));
                    builder.Clear();
                }
                
            }

            long result = 0;

            for (int i = list.Count - 1, j = 0; i >= 0; i--, j++)
            {
                result += (long)list[i] * (long)Math.Pow(7, j);
            }

            Console.WriteLine(result);
        }

        private static int Check(string s)
        {
            int n;

            switch (s)
            {
                case "f": n = 0; break;
                case "bIN": n = 1; break;
                case "oBJEC": n = 2; break;
                case "mNTRAVL": n = 3; break;
                case "lPVKNQ": n = 4; break;
                case "pNWE": n = 5; break;
                case "hT": n = 6; break;
                default: n = -1; break;
            }

            return n;
        }
    }
}
