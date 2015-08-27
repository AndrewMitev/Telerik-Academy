using System;
using System.Collections.Generic;

/*
 * @ Task
 * A dictionary is stored as a sequence of text lines containing words and their explanations.
 * Write a program that enters a word and translates it by using the dictionary.
 */
namespace _14.WordDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string> 
            { 
                {".NET", "platform for applications from Microsoft"},    
                {"CLR", "managed execution environment for .NET"},
                {"NAMESPACE", "hierarchical organization of classes"}
            };

            Console.WriteLine("Words in dictionary: " + String.Join("; ", dictionary.Keys));

            Console.Write("Enter word: ");
            string word = Console.ReadLine();

            word = word.ToUpper();

            Console.WriteLine(dictionary.ContainsKey(word) ? dictionary[word] : "No such word in dictionary");
        }
    }
}
