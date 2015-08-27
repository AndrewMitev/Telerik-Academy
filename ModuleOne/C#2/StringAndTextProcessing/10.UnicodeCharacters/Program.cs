using System;
using System.Text;

/*
 * @Task
 * Write a program that converts a string to a sequence of C# Unicode character literals.
 * Use format strings.
 */
namespace _10.UnicodeCharacters
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string word = Console.ReadLine();

            Console.WriteLine("\nResult -> {0}\n", ConvertToUnicode(word));
        }

        static string ConvertToUnicode(string word)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                builder.Append(String.Format("\\u{0:X4}", (int)word[i]));
            }

            return builder.ToString();
        }
    }
}
