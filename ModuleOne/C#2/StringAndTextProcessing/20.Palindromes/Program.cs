using System;
using System.Linq;

/*
 * @ Task
 * Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
 * 
 */
namespace _20.Palindromes
{
    class Program
    {
        private static readonly char[] separators = new char[] { ' ', '\t', ',', '!', '?', ':', ';', '(', ')', '{', '}', '[', ']' };

        static void Main(string[] args)
        {
            string text = "Hello nana, ABBA lamal, exe is not exe";

            string[] pals = text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => isPal(x))
                .ToArray();

            Console.WriteLine(String.Join(" ", pals));

        }

        private static bool isPal(string str)
        {
            int i = 0, j = str.Length - 1;
            bool flag = true;

            while (i < j)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                }
          
                i++;
                j--;
            }

            return flag;
        }
    }
}
