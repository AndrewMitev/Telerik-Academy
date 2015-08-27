using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;


/*
 * @ Task
 * Write a program that reads a list of words from the file words.txt and finds how many times each of the words is 
 * contained in another file test.txt.
 * The result should be written in the file result.txt and the words
 * should be sorted by the number of their occurrences in descending order.
 * Handle all possible exceptions in your methods.
 * Handle all possible exceptions in your methods.
 */

namespace _13.CountWords
{
    class Program
    {
        private static List<string> words;
        private static Dictionary<string, int> dict;
        private static char[] separators = new char[] {' ', ',', '.', '-' };

        static void Main(string[] args)
        {
            words = LoadWords();
            dict = new Dictionary<string, int>();

            try
            {
                StreamReader reader = new StreamReader("../../test.txt");
                string line = String.Empty;

                while (line != null)
                {
                    line = reader.ReadLine();

                    if (line != null)
                    {
                        Count(line);
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

            var sortedDict = from entry in dict orderby entry.Value descending select entry;

            WriteToFile(sortedDict);

            Console.WriteLine("Given words are successfully counted!");

        }

        private static void Count(string line)
        {
            string[] wordsFromTest = line.Split(separators);

            foreach (var word in wordsFromTest)
            {
                foreach (var w in words)
                {
                    if (word.ToUpper().Equals(w.ToUpper()))
                    {
                        if (!dict.ContainsKey(word.ToLower()))
                        {
                            dict.Add(word.ToLower(), 1);
                        }
                        else
                        {
                            dict[word.ToLower()]++;
                        }
                    }
                }
            }
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

        private static void WriteToFile(IOrderedEnumerable<KeyValuePair<string, int>> sortedDict)
        {
            try
            {
                StreamWriter writer = new StreamWriter("../../result.txt");

                using (writer)
                {
                    foreach (var word in sortedDict)
                    {
                        writer.WriteLine("{0} => {1} times.", word.Key, word.Value);
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
