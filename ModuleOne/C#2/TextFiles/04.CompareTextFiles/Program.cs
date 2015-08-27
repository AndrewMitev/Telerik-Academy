using System;
using System.IO;
/*
 * @ Task
 * Write a program that compares two text files line by line and prints the number of lines that are the same and the 
 * number of lines that are different.
 * Assume the files have equal number of lines.
 */
namespace _04.CompareTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int equalLines = 0, notEqualLines = 0;

            try
            {
                StreamReader reader = new StreamReader("../../FileOne.txt");
                StreamReader secondReader = new StreamReader("../../FileTwo.txt");

                string s1 = String.Empty;
                string s2 = String.Empty;

                while (s1 != null)
                {
                    s1 = reader.ReadLine();
                    s2 = secondReader.ReadLine();

                    if (s1 != null && s2 != null && s1.Equals(s2))
                    {
                        equalLines++;
                    }
                    else
                    {
                        notEqualLines++;
                    }
                }

                reader.Close();
                secondReader.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("FileNotFound");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException");
            }

            Console.WriteLine("Number of Equal Lines: {0}\nNumber of not equal lines: {1}", equalLines, notEqualLines);
        }
    }
}
