using System;
using System.Linq;
using System.Collections.Generic;

namespace DivisibleBy7And3
{


    static class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 4, 5, 6, 21, 22, 81, 91, 45, 49, 54, 42};
            Console.WriteLine("Filtered with Lambda:");
            Console.WriteLine(String.Join(", ", array.FilterLambda(3, 7)));

            Console.WriteLine("Filtered with LINQ:");
            Console.WriteLine(String.Join(", ", array.FilterLinq(3, 7)));

            
        }

        private static IEnumerable<int> FilterLambda(this IEnumerable<int> nums, int divider1, int divider2)
        {
            return nums.Where(x => x % divider1 == 0 && x % divider2 == 0);
        }

        private static IEnumerable<int> FilterLinq(this IEnumerable<int> nums, int divider1, int divider2)
        {
                return from num in nums
                where num % 3 == 0 && num % 7 == 0
                select num;
        }
    }
}
