using System;
using System.Text;
/*
 * @Task
 * Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less 
 * than 20, the rest of the characters should be filled with *
 * Print the result string into the console.
 */
namespace _06.StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            Console.Write("Enter string. Press Enter to stop: ");
            for (int i = 0; i < 20; i++)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.Enter)
                {
                    builder.Append('*', 20 - i);
                    break;
                }

                builder.Append(key.KeyChar);
            }
            Console.WriteLine();
            Console.WriteLine(String.Join(" ", builder));
        }
    }
}
