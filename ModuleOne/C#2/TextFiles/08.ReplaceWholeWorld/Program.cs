using System;
using System.IO;

/*
 * @ TAsk
 * Modify the solution of the previous problem to replace only whole words (not strings).
 */
namespace _07.ReplaceSubString
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader("../../Data.txt");
                StreamWriter writer = new StreamWriter("../../ModifiedDataTwo.txt");

                string line = string.Empty;

                using (writer)
                {
                    while (line != null)
                    {

                        line = reader.ReadLine();

                        if (line != null)
                        {
                            line = Modify(line);
                            writer.WriteLine(line);
                        }
                    }
                }

                reader.Close();
                Console.WriteLine("Data successfully modified.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File to write to was not found");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException");
            }
        }

        private static string Modify(string line)
        {
            line = line.Replace(" start ", "finish").Replace("start ", "finish ").Replace(" start", "finish");

            return line;
        }
    }
}
