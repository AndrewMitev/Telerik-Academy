using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;


/*
 * @ Task
 * Write a program that removes from a text file all words listed in given another text file.
 * Handle all possible exceptions in your methods.
 */

namespace _11.PrefixTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = LoadWords();
            List<string> modifiedLines = new List<string>();

            try
            {
                StreamReader reader = new StreamReader("../../text.txt");
                string line = String.Empty;

                while (line != null)
                {
                    line = reader.ReadLine();

                    if (line != null)
                    {
                        modifiedLines.Add(modLine(line, words));
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

            Console.WriteLine("Words from words.txt are successfully removed from text.txt.\nCheck modifiedText.txt to make sure.");

        }

        private static string modLine(string line, List<string> words)
        {
            foreach (string word in words)
            {
                if (line.IndexOf(word) > 0)
                {
                    line = line.Replace(word, ""); 
                }
            }

            return line;

        }

        private static List<string> LoadWords()
        {
            var words = new List<string>();

            try
            {
                StreamReader reader = new StreamReader("../../words.txt");
                string line = String.Empty;

                while (line != null)
                {
                    line = reader.ReadLine();

                    if (line != null)
                    {
                        words.Add(line);
                    }
                }

                reader.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File for words not found.");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException");
            }

            return words;
        }

        private static void WriteToFile(List<string> list)
        {
            try
            {
                StreamWriter writer = new StreamWriter("../../modifiedText.txt");

                using (writer)
                {
                    foreach (string line in list)
                    {
                        writer.WriteLine(line);
                    }
                }

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException");
            }
        }
    }
}
