using System;
using System.Text.RegularExpressions;
/*
 * @ Task
 * Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
 */
namespace _25.ExtractTextFromHtml
{
    class Program
    {
        static void Main(string[] args)
        {
            string html = "<html>" +
                            " head><title>News</title></head>" +
                            " <body><p><a href=\"http://academy.telerik.com\">Telerik" +
                            " Academy</a>aims to provide free real-world practical" +
                            " training for young people who want to turn into" +
                            " skilful .NET software engineers.</p></body>" +
                            "</html>";

            string titleContent = "None";

            int titleIndex = html.IndexOf("<title>");

            if (titleIndex > 0)
            {
                titleIndex += 7;

                int titleEndIndex = html.IndexOf("</title>");

                titleContent = html.Substring(titleIndex, titleEndIndex - titleIndex);

                Console.WriteLine(titleContent);
            }

            int bodyStart = html.IndexOf("<body>") + 6;
            int bodyEnd = html.IndexOf("</body>");

            string bodyContent = html.Substring(bodyStart, bodyEnd - bodyStart);

            bodyContent = Regex.Replace(bodyContent, "(?s)<.*?>", " ");

            Console.WriteLine("\n\nOutput:\n");

            Console.WriteLine("Title: " + titleContent);

            Console.WriteLine("\nText: " + bodyContent);
        }
    }
}
