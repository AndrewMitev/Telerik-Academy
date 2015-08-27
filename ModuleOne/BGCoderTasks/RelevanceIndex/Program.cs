using System;
using System.Collections.Generic;
using System.Linq;


namespace RelevanceIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            int numParagraphs = int.Parse(Console.ReadLine());
            SortedDictionary<int, string> dict = new SortedDictionary<int, string>();

            char[] symbols = new char[] { ',', '.', '(', ')', ';', '-', '!', '?', ' ' };

            List<string> sortedList = new List<string>();

            for (int i = 0; i < numParagraphs; i++)
            {
                string data = Console.ReadLine();

                string[] words = data.Split(symbols, StringSplitOptions.RemoveEmptyEntries);
                int count = 0;

                for (int j = 0; j < words.Length; j++)
                {
                    if (key.ToUpper().Equals(words[j].ToUpper()))
                    {
                        words[j] = key.ToUpper();
                        count++;
                    }
                }

                dict.Add(count, String.Join(" ", words));
            }



            foreach (var element in dict.Reverse())
            {
                Console.WriteLine(element.Value);
            }
        }
    }
}
