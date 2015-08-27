using System;
using System.Net;
/*
 * @ Task
 * Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
 * Find in Google how to download files in C#.
 * Be sure to catch all exceptions and to free any used resources in the finally block.
 */
namespace _04.DownloadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WebClient myWeb = new WebClient();
                myWeb.DownloadFile("https://www.google.bg/search?q=cool+naked+girl&biw=1366&bih=643&source=lnms&tbm=isch&sa=X&ei=bLTwVKOOLseAUe37grgL&ved=0CAYQ_AUoAQ&dpr=1#tbm=isch&q=cool+erotic+girl&imgdii=_&imgrc=8G_4CXocyAK7eM%253A%3BOmIJ6IlEjHg3tM%3Bhttp%253A%252F%252Fwww.lexiyoga.com%252Fimages%252Fsexywoman.jpg%3Bhttp%253A%252F%252Fwww.lexiyoga.com%252Fsex-quotes%3B203%3B297", "sexygirl.jpg");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("argument null exception has occured");
            }
            catch (WebException)
            {
                Console.WriteLine("Sorry! Couldn't get the resource!");
            }

            Console.WriteLine("Image successfully downloaded! Check program's Debug folder.");
        }
    }
}
