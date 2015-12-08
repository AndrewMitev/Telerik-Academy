namespace _1.PositiveIntegerNumbers
{
    using System;
    using System.Collections.Generic;
    using Helpers;

    public class Startup
    {
        public static void Main()
        {
            List<int> sequence = new List<int>();
            ConsoleTool.LoadSequence(sequence);

            Console.WriteLine("Sum of sequence: " + CalculateSum(sequence));
            Console.WriteLine("Average of sequence: " + CalculateAverage(sequence));
        }

        private static long CalculateSum(ICollection<int> data)
        {
            long sum = 0;
            foreach (var item in data)
            {
                sum += item;

            }

            return sum;
        }

        private static float CalculateAverage(ICollection<int> data)
        {
            float average = (float)CalculateSum(data) / data.Count;

            return average;
        }
    }
}
