using System;
using System.Text;

/*
 * @ Task
 * Write a program that reverses the words in given sentence.
 */
namespace _13.ReverseSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();

            string text = "C# is not C++, not PHP and not Delphi!";

            string[] words = text.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--)
            {
                builder.Append(words[i]);
                builder.Append(" ");
            }

            Console.WriteLine(builder);
        }
    }
}
