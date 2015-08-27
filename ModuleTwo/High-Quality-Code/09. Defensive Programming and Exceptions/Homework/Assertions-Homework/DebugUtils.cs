namespace Assertions_Homework
{
    using System;
    using System.Linq;
    using System.Diagnostics;

    public class DebugUtils
    {
        internal static bool IsSorted<T>(T[] array) where T : IComparable<T>
        { 
            var element = array.First();

            return array.Skip(1).All(x => 
            {
                bool isBigger = element.CompareTo(x) < 0;
                element = x;

                return isBigger;
            });
        }

        internal static bool IsMinimalElement<T>(T[] array, T element, int startIndex, int endIndex) where T : IComparable<T>
        {
            return array.Skip(1)
                .Take(endIndex - startIndex)
                .Min()
                .Equals(element);
        }
    }
}
