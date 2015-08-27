using System;
using System.Text;

/*
 * @Task
 * Write a program that extracts from a given text all sentences containing given word.
 */
namespace _08.ExtractSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string key = " in ";
           
            string[] sentences = text.Split('.');

            foreach (string sent in sentences)
            {
                if (sent.IndexOf(key) > 0)
                {
                    builder.Append(sent);
                    builder.Append(". ");
                }
            }
            
            Console.WriteLine(builder);
        }
    }
}
