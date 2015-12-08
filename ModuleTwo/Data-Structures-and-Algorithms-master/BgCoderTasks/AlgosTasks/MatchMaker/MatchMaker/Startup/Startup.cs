namespace Startup
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        private static string input = @"2
Pesho
m
1
ski
Mariika
f
1
ski";

        private static Dictionary<string, List<string>> vertices;
        private static SortedSet<string> guys;
        private static HashSet<string> girls;

        public static void Main()
        {
            vertices = new Dictionary<string, List<string>>();
            guys = new SortedSet<string>();
            girls = new HashSet<string>();

            //FakeInput();
            ReadInput();
            Solve();
        }

        private static void Solve()
        {
            Dictionary<string, int> matches = new Dictionary<string, int>();

            foreach (var male in guys)
            {
                foreach (var interest in vertices[male])
                {
                    if (vertices.ContainsKey(interest))
                    {
                        foreach (var girl in vertices[interest])
                        {
                            string key = male + " and " + girl;

                            if (!matches.ContainsKey(key))
                            {
                                matches.Add(key, 1);
                            }
                            else
                            {
                                matches[key]++;
                            }
                        }
                    }
                }
            }

            var result = matches.OrderByDescending(x => x.Value).ThenBy(x => x.Key).FirstOrDefault();

            string intr = result.Value > 1 ? "interests" : "interest"; 
            Console.WriteLine(result.Key + " have " + result.Value + " common " + intr + "!");    
        }

        private static void ReadInput()
        {
            int numOfParticipants = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfParticipants; i++)
            {
                string name = Console.ReadLine();
                string gender = Console.ReadLine();
                string nothing = Console.ReadLine();
                string[] interests = Console.ReadLine().Split(' ').ToArray();

                foreach (var interest in interests)
                {
                    if (gender == "m")
                    {
                        if (!vertices.ContainsKey(name))
                        {
                            vertices.Add(name, new List<string>());
                            guys.Add(name);
                        }

                        vertices[name].Add(interest);
                    }
                    else
                    {
                        if (!vertices.ContainsKey(interest))
                        {
                            vertices.Add(interest, new List<string>());
                        }

                        girls.Add(name);
                        vertices[interest].Add(name);
                    }
                }
            }
        }

        private static void FakeInput()
        {
            Console.SetIn(new StringReader(input));
        }
    }
}
