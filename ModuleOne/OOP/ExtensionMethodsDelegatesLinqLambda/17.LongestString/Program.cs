using System;
using System.Linq;


namespace _17.LongestString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = {"sdsdsd", "dkejflwejfknvek", "ko?", "ne." };

            var sorted =
                from st in array
                orderby st.Length descending
                select st;

            Console.WriteLine("Longest string:\n");
            Console.WriteLine(sorted.FirstOrDefault());
            Console.WriteLine();
        }
    }
}
