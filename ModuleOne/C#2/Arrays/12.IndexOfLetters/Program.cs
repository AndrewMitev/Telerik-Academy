using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Write a program that creates an array containing all letters from the alphabet (A-Z).
 * Read a word from the console and print the index of each of its letters in the array.
 */
namespace _12.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];
            byte num = 97;
            string word = Console.ReadLine();

            for (int i = 0; i < alphabet.Length; i++)
            {
               
                alphabet[i] = (char)num++;
            }

            for (int i = 0; i < word.Length; i++)
            {
                char symbol = word[i];

                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (symbol == alphabet[j])
                    {
                        Console.WriteLine(j);
                    }
                }
            }
        }
    }
}
