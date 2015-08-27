using System;
using System.IO;
using System.Collections.Generic;

/*
 * @ Task
 * Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
 */
namespace _06.SaveSortedNames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = LoadListOfNames();

            list.Sort();

            try 
            {
                StreamWriter writer = new StreamWriter("../../SortedNames.txt");

                using (writer)
                {
                    foreach (string name in list)
                    {
                        writer.WriteLine(name);
                    }

                    Console.WriteLine("Sorted names are successfully load to SortedNames.txt");
                }
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
        private static List<string> LoadListOfNames()
        {
            List<string> names = new List<string>();

            try
            {
                StreamReader reader = new StreamReader("../../Data.txt");

                using (reader)
                {
                    string name = String.Empty;
                    do
                    {
                        name = reader.ReadLine();

                        if (name != null)
                        {
                            names.Add(name);
                        }
                    }
                    while(name != null);
                }

                return names;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("FileNotFound");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException");
            }

            return null;
        }
    }
}
