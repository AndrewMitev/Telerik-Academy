namespace TextFileDictionary
{
    using System;
    using System.IO;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("../../Data.txt");
            SortedDictionary<string, List<string>> dictionary = new SortedDictionary<string, List<string>>();
            string line;

            using (reader)
            {
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    string name = words[0] + " " + words[1];
                    string course = words[2];

                    if (!dictionary.ContainsKey(course))
                    {
                        dictionary.Add(course, new List<string>());
                    }

                    dictionary[course].Add(name);
                }
            }

            foreach (var item in dictionary)
            {
                Console.Write(item.Key + " " + string.Join(", ", item.Value));
                Console.WriteLine();
            }
        }
    }
}
