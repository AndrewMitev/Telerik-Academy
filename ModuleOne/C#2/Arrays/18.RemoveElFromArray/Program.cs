using System;
using System.Collections.Generic;


/*! Isn't working !!!
 * Write a program that reads an array of integers and removes from it a minimal number of 
 * elements in such a way that the remaining array is sorted in increasing order.
 * Print the remaining sorted array.
 */
namespace _18.RemoveElFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
            int[] length = new int[arr.Length];
            int[] pre = new int[arr.Length];
            int maxLength = 0, bestEnd = 0;

            length[0] = 1;
            pre[0] = 1;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                length[i] = 1;
                pre[i] = -1;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (length[j] + 1 > length[i] && arr[j] < arr[i])
                    {
                        length[i] = length[j] + 1;
                        pre[i] = j;
                    }
                }

                if (length[i] > maxLength)
                {
                    bestEnd = i;
                    maxLength = length[i];
                }
            }

            int ind = bestEnd;

            while (ind != -1)
            {
                Console.WriteLine(" " + arr[ind] + " ");
                ind = pre[ind];
            }
        }
    }
}
