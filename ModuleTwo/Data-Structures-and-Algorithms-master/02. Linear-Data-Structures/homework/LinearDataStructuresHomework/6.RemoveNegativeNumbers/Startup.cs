namespace _6.RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<int> numbers = new List<int>() { 2, 3, -5, 1, 2222222, -23343543, -9, 33};

            List<int> removedNegativeNumbers = numbers.Where(x => x >= 0).ToList();

            removedNegativeNumbers.ForEach(x => Console.WriteLine(x));
        }
    }
}
