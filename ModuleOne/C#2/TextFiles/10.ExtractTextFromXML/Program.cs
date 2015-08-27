using System;
using System.IO;
using System.Text;

/*
 * @ Task
 * Write a program that extracts from given XML file all the text without the tags.
 */

namespace _10.ExtractTextFromXML
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();

            try
            {
                StreamReader reader = new StreamReader("../../info.xml");

                string line = reader.ReadLine();
                int start = 0, end = 0;

                while (true)
                {
                    start = line.IndexOf(">", start + 1);
                    if (start != -1)
                    {
                        end = line.IndexOf("<", start);
                    }

                    if (start != end - 1 && start != -1 && end != -1)
                    {
                        builder.Append(line.Substring(start + 1, end - start - 1) + " ");
                    }

                    if (start == -1)
                    {
                        break;
                    }
                }

                Console.WriteLine("Extracted data: \n" + builder);
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
