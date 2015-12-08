namespace Bunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            var inputAnswers = line.Split(' ').Select(int.Parse).ToList();
            inputAnswers.RemoveAt(inputAnswers.Count - 1);

            int result = CountRabbits(inputAnswers);

            Console.WriteLine(result);
        }

        private static int CountRabbits(IEnumerable<int> inputAnswers)
        {
            Dictionary<int, int> groups = new Dictionary<int, int>();

            foreach (int answer in inputAnswers)
            {
                if (!groups.ContainsKey(answer + 1))
                {
                    groups.Add(answer + 1, 0);
                }

                groups[answer + 1]++;
            }

            int rabbits = 0;

            foreach (var group in groups)
            {
                int groupSize = group.Key;
                int numberOfRabbitsInGroup = group.Value;

                int actualGroups = (int)Math.Ceiling(numberOfRabbitsInGroup / (decimal)groupSize);
                rabbits += actualGroups * groupSize;
            }

            return rabbits;
        }
    }
}
