using System;
using System.IO;
using System.Text;
/*
 * @ Task
 * Write a program that deletes from given text file all odd lines.
 * The result should be in the same file.
 */

namespace _09.DeleteOddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader("../../TextFile.txt");
                

                string line = String.Empty;

                StringBuilder builder = new StringBuilder();

                int counter = 1;

                while (line != null)
                {
                    line = reader.ReadLine();

                    if (counter % 2 != 0)
                    {
                        builder.Append(line + "\n");
                    }

                    counter++;
                }
                
                reader.Close();

                StreamWriter writer = new StreamWriter("../../TextFile.txt");

                using (writer)
                {
                    writer.Write(builder);
                }

                Console.WriteLine("Even lines are successfully removed!");

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("FileNotFoundException");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException");
            }
        }
    }
}
