using System;
using System.Text;
/*
 * @Task
 * Write a program that reads a string, reverses it and prints the result at the console.
 */
namespace _02.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();

            string text = "sample";
            
            for (int i = text.Length - 1; i >= 0; i--)
            {
                builder.Append(text[i]);
            }

            Console.WriteLine(builder);
        }
    }
}
