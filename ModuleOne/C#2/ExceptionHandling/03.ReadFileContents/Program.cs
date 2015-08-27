using System;
using System.IO;

/*
 * @ Task
 * Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
 * reads its contents and prints it on the console.
 * Find in MSDN how to use System.IO.File.ReadAllText(…).
 * Be sure to catch all possible exceptions and print user-friendly error messages.
 */
namespace _03.ReadFileContents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full file path NOW!!!");
            string path = Console.ReadLine();
            string readText = "DEFAULT_VALUE";

            try
            {
                readText = File.ReadAllText(path);
                Console.WriteLine(readText);

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid directory. How could you enter something so stupid ?!?");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Too long path.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Such directory doesn't exist at all!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Such file doesn't exist at all!");
            }
            catch (IOException)
            {
                Console.WriteLine("I/O Exception");
            }

        }
    }
}
