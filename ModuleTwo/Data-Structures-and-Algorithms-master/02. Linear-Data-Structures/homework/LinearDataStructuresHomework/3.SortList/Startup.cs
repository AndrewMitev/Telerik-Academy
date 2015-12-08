namespace _3.SortList
{
    using Helpers;
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main(string[] args)
        {
            List<int> sequence = new List<int>();

            ConsoleTool.LoadSequence(sequence);

            sequence.Sort();

            foreach (var item in sequence)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
