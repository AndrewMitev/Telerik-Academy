namespace SecondTask
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            string[] words = new string[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            HashSet<string> oddWords = new HashSet<string>();

            foreach (var word in words)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }

            foreach (var item in dictionary)
            {
                if (item.Value % 2 != 0)
                {
                    oddWords.Add(item.Key);
                }
            }

            Console.WriteLine("Words that are met odd number of times:");
            foreach (var item in oddWords)
            {
                Console.WriteLine(item);
            }
        }
    }
}
