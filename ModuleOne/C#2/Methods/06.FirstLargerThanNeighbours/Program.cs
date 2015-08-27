using System;

/*
 * Write a method that returns the index of the 
 * first element in array that is larger than its neighbours, or -1, if there’s no such element.
 * Use the method from the previous exercise.
 */
namespace _06.FirstLargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 11, 12, 14, 0, 9, 8};
            int position = -1;

            for (int i = 1; i < array.Length - 1; i++)
            {
                position = CheckNeighboursOf(array, i);

                if (position != -1)
                {
                    break;
                }
            }

            Console.WriteLine(position);
        }

        private static int CheckNeighboursOf(int[] array, int position)
        {
            if (position <= 0 || position >= array.Length)
            {
                Console.WriteLine("Invalid parameter");
                Environment.Exit(0);
            }

            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                return position;
            }
            else
            {
                return -1;
            }
        }
    }
}
