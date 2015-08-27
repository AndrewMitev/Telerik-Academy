using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
 * Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 */
namespace _07.SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 21, 18, 29, 301, 44 };
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j]) // swap items
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++) // print sorted array
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
