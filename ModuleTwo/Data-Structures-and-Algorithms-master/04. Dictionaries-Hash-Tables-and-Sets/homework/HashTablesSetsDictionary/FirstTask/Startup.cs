namespace FirstTask
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main(string[] args)
        {
            double[] array = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            SortedDictionary<double, int> dictionary = new SortedDictionary<double, int>();

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

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} --> {1} times", item.Key, item.Value);
            }
        }
    }
}
