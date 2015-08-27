using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;


/*
 * @ Task
 * Write a program that deletes from a text file all words that start with the prefix test.
 * Words contain only the symbols 0…9, a…z, A…Z, _.
 */

namespace _11.PrefixTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> modifiedLines = new List<string>();
            
            try
            {
                StreamReader reader = new StreamReader("../../TextFile.txt");

                string line = String.Empty;
                int start, end;

                while (line != null)
                {
                    line = reader.ReadLine();
                    start = 0;
                    end = 0;
                    list.Clear();

                    if (line != null)
                    {
                        while (start != -1)
                        {
                            start = line.IndexOf("test", start + 1);

                            if (start != -1)
                            {
                                end = line.IndexOf(" ", start);

                                if (end != -1)
                                {
                                    if (CheckWord(line.Substring(start, end - start)))
                                    {
                                        list.Add(line.Substring(start, end - start));
                                    }
                                }
                                // if word is at the end of the line.
                                else if (end == -1 && start != -1)
                                {
                                    if (CheckWord(line.Substring(start, line.Length - start)))
                                    {
                                        list.Add(line.Substring(start, line.Length - start));
                                    }
                                }
                            }

                        } // end while
                        // remove unnecessary words.
                        foreach (string word in list)
                        {
                            line = line.Replace(word + " ", "");
                        }

                        modifiedLines.Add(line);
                    }
                }

                reader.Close();

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("FileNotFoundException");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException");
            }

            WriteToFile(modifiedLines);
        }

        private static bool CheckWord(string word)
        {
            return Regex.IsMatch(word, "^[a-zA-Z0-9_]+$");
        }

        private static void WriteToFile(List<string> list)
        {
            try
            {
                StreamWriter writer = new StreamWriter("../../TextFile.txt");

                using (writer)
                {
                    foreach (string line in list)
                    {
                        writer.WriteLine(line);
                    }
                }

                Console.WriteLine("Data is successfully modified!");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException");
            }
        }
    }
}
