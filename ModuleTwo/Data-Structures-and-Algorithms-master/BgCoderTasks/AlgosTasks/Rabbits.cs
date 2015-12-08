namespace Rabbits
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main()
        {
            var line = Console.ReadLine();

            var answers = line.Split(' ').Select(int.Parse).ToList();
            answers.RemoveAt(answers.Count - 1);

            var groups = new Dictionary<int, int>();

            foreach (var answer in answers)
            {
                if (!groups.ContainsKey(answer + 1))
                {
                    groups.Add(answer + 1, 0);
                }

                groups[answer + 1]++;
            }

            var rabbits = 0;

            foreach (var group in groups)
            {
                var size = group.Key;
                var rabbitsInGroup = group.Value;
                var groupsCount = (int)Math.Ceiling(rabbitsInGroup / (decimal)size);

                rabbits += groupsCount * size;

            }

            Console.WriteLine(rabbits);

        }
    }
}
