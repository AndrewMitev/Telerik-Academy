namespace _4.GreatestSequence
{
    using Helpers;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Made it really ugly. Sorry. No time for refacturing. Not worthed.
    /// </summary>
    public class Startup
    {
        public static void Main(string[] args)
        {
            int max = int.MinValue;

            List<List<int>> allSequences = new List<List<int>>();

            List<int> allNumbers = new List<int>();
            List<int> longestSequence = new List<int>();

            ConsoleTool.LoadSequence(allNumbers);

            for (int i = 0; i < allNumbers.Count - 1; i++)
            {
                int currentNumber = allNumbers[i];

                i = LoadListOfLists(i, currentNumber, allSequences, allNumbers);
            }

            foreach (var sequence in allSequences)
            {
                if (sequence.Count > max)
                {
                    max = sequence.Count;
                    longestSequence = sequence;
                }
            }

            Console.WriteLine("Longest sequence is:");
            foreach (var item in longestSequence)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        private static int LoadListOfLists(int index, int currentNumber, List<List<int>> allSequences, List<int> allNumbers)
        {
            int exitIndexForOuterCounter = index;

            List<int> currentSequence = new List<int>();
            currentSequence.Add(currentNumber);

            for (int j = index + 1; j < allNumbers.Count; j++)
            {
                int checkNumber = allNumbers[j];
                exitIndexForOuterCounter = j;

                if (currentNumber == checkNumber)
                {
                    currentSequence.Add(checkNumber);
                }
                else
                {
                    break;
                }
            }

            if (currentSequence.Count > 1)
            {
                allSequences.Add(currentSequence);
            }

            index = exitIndexForOuterCounter - 1;

            return index;
        }

        private static void DisplayListsinList(List<List<int>> sequences)
        {
            foreach (var sequence in sequences)
            {
                foreach (var number in sequence)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
