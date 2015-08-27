using System;

/*
 * Write a method that return the maximal element in a portion of array of integers starting at given index.
 * Using it write another method that sorts an array in ascending / descending order.
 */
namespace _09.SortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 11, 9, 45, 12, 32, 8, 4, -2, 0, 1};

            SortArray(array);

            Console.WriteLine(String.Join(" ", array));
        }

        public static int MaxElementInPortion(int[] array, int starting)
        {
            int max = -1;
            int index = -1;

            for (int i = starting; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }

            return index;
        }

        public static void SortArray(int[] array)
        {
            int max = int.MinValue;
            int maxIndex = -1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                maxIndex = MaxElementInPortion(array, i);
                max = array[maxIndex];


                if (array[i] < max)
                {
                    int temp = array[i];
                    array[i] = max;
                    array[maxIndex] = temp;
                }
            }

        }
    }
}
