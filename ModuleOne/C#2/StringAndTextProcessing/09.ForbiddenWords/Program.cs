using System;

/*
 * @Task
 * We are given a string containing a list of forbidden words and a text containing some of these words.
 * Write a program that replaces the forbidden words with asterisks.
 */
namespace _09.ForbiddenWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is" +
            "based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

            Console.WriteLine("Initial text:\n" + text);

            string[] forbidden = {"Microsoft", "CLR", "PHP"};

            text = hideForbidden(text, forbidden);

            Console.WriteLine("\nCoded text: \n" + text);

        }

        private static string hideForbidden(string text, string[] par)
        {
            foreach (string item in par)
            {
                text = text.Replace(item, new string('*', item.Length));
            }

            return text;
        }
    }
}
