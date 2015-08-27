using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/*
 * Write a program that reads a string from the console and lists all different words in the string along with information 
 * how many times each word is found.
 */
namespace _22.WordsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, int> dict = new Dictionary<string, int>();

            string txt = "Hello you stupid motherfucker! @wk how ef35k is this?";

            string reg = Regex.Replace(txt, "[^a-zA-Z ]", "");

            string[] words = reg.Split(' ');

            foreach (string word in words)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }

            foreach (var word in dict)
            {
                Console.WriteLine("{0} => {1} times", word.Key, word.Value);
            }
        }
    }
}
