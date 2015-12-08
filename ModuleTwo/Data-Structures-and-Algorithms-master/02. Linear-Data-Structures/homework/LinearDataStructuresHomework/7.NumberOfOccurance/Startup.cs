namespace _7.NumberOfOccurance
{
    using System.Collections.Generic;
    using Helpers;

    public class Startup
    {
        public static void Main()
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            int[] array = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            foreach (var number in array)
            {
                if (dictionary.ContainsKey(number))
                {
                    dictionary[number]++;
                }
                else
                {
                    dictionary.Add(number, 1);
                }
            }

            ConsoleTool.DisplayDictionaryForTaskSeven(dictionary);
        }
    }
}
