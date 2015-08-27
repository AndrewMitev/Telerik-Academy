using System;
using System.Collections.Generic;
/*
 * @ Task
 * Write a program that reads a string from the console and prints all different letters in the string along with information 
 * how many times each letter is found.
 */
namespace _21.LettersCount
{
    class Program
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        static void Main(string[] args)
        {

            string text = "Hello, how are you?";

            CheckLetters(text);
        }

        private static void CheckLetters(string txt)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < txt.Length - 1; i++)
            {
                if (Char.IsLetter(txt[i]))
                {
                    char letter = Char.ToUpper(txt[i]);

                    if (dict.ContainsKey(letter))
                    {
                        dict[letter]++;
                    }
                    else
                    {
                        dict.Add(letter, 1);
                    }
                }
            }

            foreach (var letter in dict)
            {
                Console.WriteLine("{0} => {1} times", letter.Key, letter.Value);
            }
        }
    }
}
