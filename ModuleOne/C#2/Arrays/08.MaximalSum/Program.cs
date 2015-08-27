using System;

/* Problem 8.
     * Write a program that finds the sequence of maximal sum in given array.
     * Can you do it with only one loop (with single scan through the elements of the array)?
 */

class MaximalSum
{
    static void Main()
    {

        int[] array = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int sum = array[0];
        int bestSum = int.MinValue;
        int bestStart = 0;
        int bestLen = 1;
        int start = 0;
        int len = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] >= sum + array[i])
            {
                start = i;
                len = 1;
                sum = array[i];
            }
            else
            {
                len++;
                sum += array[i];
            }

            if ((sum > bestSum) ||
                (sum == bestSum && len < bestLen) ||
                (sum == bestSum && len == bestLen && start < bestStart))
            {
                bestStart = start;
                bestLen = len;
                bestSum = sum;
            }
        }

        Console.WriteLine(bestSum);

        for (int i = 0; i < bestLen; i++)
        {
            Console.Write(array[bestStart++] + " ");    
        }
        
        Console.WriteLine();
    }
}
