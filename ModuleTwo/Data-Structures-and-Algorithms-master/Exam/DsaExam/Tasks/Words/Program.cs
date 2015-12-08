using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            long whole = Kmp(word, text);

            long totalCount = whole > 0 ? whole : 0;

            for (int i = 1; i < word.Length; i++)
            {
                string pref = word.Substring(0, i);
                string suff = suff = word.Substring(i, word.Length - i);

                long prefCount = Kmp(pref, text);
                long suffCount = Kmp(suff, text);

                totalCount += (prefCount * suffCount);
            }

            Console.WriteLine(totalCount);
        }

        private static long Kmp(string pattern, string text)
        {
            long counter = 0;
            int n = text.Length;
            int m = pattern.Length;

            for (int i = 0; i <= n - m; i++)
            {
                int matched = 0;

                while (matched < m)
                {
                    if (text[i + matched] != pattern[matched])
                    {
                        break;
                    }

                    matched++;
                }

                if (matched == m)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
