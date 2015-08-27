using System;

/*
 * @Task
 * You are given a text. Write a program that changes the text in all 
 * regions surrounded by the tags <upcase> and </upcase> to upper-case.
 * The tags cannot be nested.
 */
namespace _05.ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            int begin = 0, end = 0, length = 0;

            while (begin != 7)
            {
                begin = text.IndexOf("<upcase>", begin) + 8;
                end = text.IndexOf("</upcase>", end);

                length = end - begin;

                if (length > 0)
                {
                    string modify = text.Substring(begin, length);
                    text = text.Replace(modify, modify.ToUpper());
                }
      

                if (begin != 7)
                {
                    begin += 1;
                    end += 1;
                }

            }
            text = text.Replace("<upcase>", "");
            text = text.Replace("</upcase>", "");

            Console.WriteLine(text);
        }
    }
}
