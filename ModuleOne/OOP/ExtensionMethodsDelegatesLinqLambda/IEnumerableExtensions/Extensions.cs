using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> collection) where T : struct
        {
            dynamic sum = 0;

            foreach (var item in collection)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection) where T : struct
        {
            dynamic product = 1;

            foreach (var item in collection)
            {
                product *= item;
            }

            return product;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : struct
        {
            return collection.Max();
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : struct
        { 
            return collection.Min();
        }

        public static T Average<T>(this IEnumerable<T> collection) where T : struct
        {
            return collection.Average();
        }
    }
}
