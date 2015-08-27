using System;
using System.Collections.Generic;
using System.Text;

namespace MagicWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < N; i++)
            {
                list.Add(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                string word = list[i];
                int position = word.Length % (N + 1);

                list[i] = null;
                list.Insert(position, word);
                list.Remove(null);

            }

            int maxLength = 0;
            StringBuilder builder = new StringBuilder();

            foreach (string word in list)
            {
                if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                }
            }

            for (int i = 0; i < maxLength; i++)
            {
                foreach (string word in list)
                {
                    if (i < word.Length)
                    {
                        builder.Append(word[i]);
                    }
                }
            }

            Console.WriteLine(builder);

        }
    }
}
