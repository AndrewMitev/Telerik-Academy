using System;

/*
 * @Task
 * 
 * Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] 
 * and extracts from it the [protocol], [server] and [resource] elements.
 */
namespace _12.ParseURL
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://telerikacademy.com/Courses/Courses/Details/212";

            Console.WriteLine("[protocol] = " + url.Substring(0, url.IndexOf(":")));
            
            int secondMargin = url.IndexOf("/", 7);
            int firstMargin = url.IndexOf("://") + 3;

            Console.WriteLine("[server] = " + url.Substring(firstMargin, secondMargin - firstMargin));

            Console.WriteLine("[resource] = " + url.Substring(secondMargin));
        }
    }
}
