using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BoxFullOfBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            //MockInput();
            long[] possibleTakes = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[] ab = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long a = ab[0];
            long b = ab[1];

            var answer = Solve(possibleTakes, a, b);
            Console.WriteLine(answer);
        }

        private static long Solve(long[] possibleTakes, long a, long b)
        {
            long count = 0;

            // TODO: directly pass hash if is slow!
            HashSet<long> takes = new HashSet<long>(possibleTakes);
            bool[] isThereSolution = new bool[b]; //last index is b - 1

            for (long ballsGame = a; ballsGame <= b; ballsGame++)
            {
                if (takes.Contains(ballsGame))
                {
                    count++;
                    isThereSolution[ballsGame - 1] = true;
                    continue;
                }

                //algo here
                foreach (long take in takes)
                {
                    long prevIndexGame = 0;

                    if (ballsGame > take)
                    {
                        prevIndexGame = ballsGame - take - 1;
                    }

                    if (isThereSolution[prevIndexGame])
                    {
                        isThereSolution[ballsGame - 1] = false;
                    }
                    else
                    {
                        count++;
                        isThereSolution[ballsGame - 1] = true;
                        break;
                    }
                }
                // end here algo ====
            }

            return count;
        }

        private static void MockInput()
        {
            string input = @"1 100
1 100000";

            Console.SetIn(new StringReader(input));
        }
    }
}
