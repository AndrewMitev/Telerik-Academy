using System;

/*
 * @Task
 * Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive  search)
 * 
 */
namespace _04.SubstringInText
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "The text is as follows: We are living in an yellow submarine. We don't" +
            "have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            text = text.ToLower();

            string search = "in";

            search = search.ToLower();

            int position = 0, counter = 0;

            while (position != -1)
            {
                position = text.IndexOf(search, position);

                if (position != -1)
                {
                    position += 1;
                }

                counter++;
            }

            Console.WriteLine("The word \'{0}\' is contained {1} times in the text", search, counter - 1);
        }
    }
}
