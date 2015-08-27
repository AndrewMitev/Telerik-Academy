using System;
using System.Text;
using System.Collections.Generic;

/*
 * @ Task
 * Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
 */
namespace _23.SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "aaaaabbbbbcdddeeeedssaaf";

            Console.WriteLine(Trim(txt));
        }

        private static string Trim(string txt)
        {
            List<int> positions = new List<int>();
            StringBuilder builder = new StringBuilder();

            for (int i = 1; i < txt.Length; i++)
            {
               if (txt[i] == txt[i - 1])
               {
                   positions.Add(i);
               }
            }

            for (int i = 0; i < txt.Length; i++)
            {
                if (!positions.Contains(i))
                {
                    builder.Append(txt[i]);
                }
            }

            return builder.ToString();
        }
    }
}
