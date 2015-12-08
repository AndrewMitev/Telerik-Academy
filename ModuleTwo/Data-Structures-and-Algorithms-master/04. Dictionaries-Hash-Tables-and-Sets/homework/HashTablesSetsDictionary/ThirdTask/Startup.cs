namespace ThirdTask
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            FileUtil.File = "../../randomWords.txt";
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            string[] wordsFromFile = FileUtil.ReadAllWords();

            foreach (string word in wordsFromFile)
            {
                string wordToLower = word.ToLower();

                if (dictionary.ContainsKey(wordToLower))
                {
                    dictionary[wordToLower]++;
                }
                else
                {
                    dictionary.Add(wordToLower, 1);
                }
            }

            var sortedDic = from entry in dictionary orderby entry.Value ascending select entry; 

            Console.WriteLine("Words sorted:");

            foreach (var item in sortedDic)
            {
                Console.WriteLine("{0} --> {1} times", item.Key, item.Value);
            }
        }
    }
}
