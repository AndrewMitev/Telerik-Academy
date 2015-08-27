using System;
using System.Text;
using System.IO;
/*
 * @ Task
 * Write a program that reads a text file and inserts line numbers in front of each of its lines.
 * The result should be written to another text file.
 */
namespace _03.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader(@"../../RandomText.txt");
                StringBuilder appender = new StringBuilder();

                using (reader)
                {
                    StreamWriter writer = new StreamWriter("../../NumberedLines.txt");

                    using (writer)
                    {
                        int counter = 0;


                        string line = String.Empty;

                        while (line != null)
                        {
                            line = reader.ReadLine();
                            appender.Append(counter + ". " + line);
                            counter++;
                            writer.WriteLine(appender);
                            appender.Clear();
                        }
                    }

                }
                Console.WriteLine("Done.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }

        }
    }
}
