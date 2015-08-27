using System;

/*
 * Write a method that checks if the element at given position in given array 
 * of integers is larger than its two neighbours (when such exist).
 */
namespace _05.LargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,45,66,4,43,33,5,34,52311,11,1,3 };

            int position = 5;

            Console.WriteLine(CheckNeighboursOf(array, position));
        }

        private static bool CheckNeighboursOf(int[] array, int position)
        {
            if (position <= 0 || position >= array.Length)
            {
                Console.WriteLine("Invalid parameter");
                Environment.Exit(0);
            }

            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
