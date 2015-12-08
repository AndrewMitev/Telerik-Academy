namespace RepeatingPattern
{
    using System;

    public class Startup
    {
        static void Main()
        {
            var pattern = Console.ReadLine();
            var searchFor = pattern + pattern;

            var links = new int[pattern.Length + 1];
            links[0] = -1;
            links[1] = 0;

            for (int i = 1; i < pattern.Length; i++)
            {
                int j = links[i];
                while (j >= 0 && pattern[i] != pattern[j])
                {
                    j = links[j];
                }

                links[i + 1] = j + 1;
            }

            int match = 0;
            for (int i = 1; i < searchFor.Length; i++)
            {
                while (match >= 0 && searchFor[i] != pattern[match])
                {
                    match = links[match];
                }

                match++;

                if (match == pattern.Length) 
                {
                    Console.WriteLine(pattern.Substring(0, i - pattern.Length + 1));
                    break;
                }
            }
             
        }
    }
}
