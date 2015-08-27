using System;

/*
 * @ Task
 * Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
 */
namespace _24.OrderWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = "beer bitches some milk and appples to fuck";
            
            string[] words = sequence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length - 1; j++)
                {
                    if (String.Compare(words[j], words[j + 1]) > 0)
                    {
                        string swap = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = swap;
                    }
                }
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
