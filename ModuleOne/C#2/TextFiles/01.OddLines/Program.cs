using System;
using System.IO;
/*
 * @ Task
 * Write a program that reads a text file and prints on the console its odd lines.
 */
namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader("OddLines.txt");

                using (reader)
                {
                    int lineCount = 0;
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        line = reader.ReadLine();
                        lineCount++;

                        if (lineCount % 2 != 0)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Null Reference Exception");
            }
        }
    }
}
