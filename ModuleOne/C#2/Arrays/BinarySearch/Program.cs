using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
 */
namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {99, 88, 77, 32, 21, 20, 18, 17, 14, 12, 8, 9, 5, 3, 1};

            int value = 3;
            int index = -1;

            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (array[middle] == value)
                {
                    index = middle;
                    break;
                }
                else if (array[middle] > value)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
                Console.WriteLine();
            }

            Console.WriteLine(index);
        }
    }
}
