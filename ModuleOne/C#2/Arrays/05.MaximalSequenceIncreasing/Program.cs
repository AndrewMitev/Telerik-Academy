using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Write a program that finds the maximal increasing sequence in an array.
 */
namespace _05.MaximalSequenceIncreasing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 2, 3, 2, 2, 4, 5, 6, 7, 8 };

            int maxCounter = 0, initialValue = 0; //Mark the lenght and beggining of the longest sequence. You'll get it, i'm sure, but just in case i'm adding this comment :)

            for (int i = 0; i < array.Length - 1; i++)
            {
                int tempCounter = 1;

                for (int j = i; j < array.Length - 1; j++)
                {
                    if (array[j] == array[j + 1] - 1)
                    {
                        tempCounter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (tempCounter > maxCounter)
                {
                    maxCounter = tempCounter;
                    initialValue = array[i];
                }
            }

            for (int i = 0; i < maxCounter; i++)
            {
                if (i != maxCounter - 1)
                {
                    Console.Write(initialValue++ + ",");
                }
                else
                {
                    Console.Write(initialValue);
                }
            }

            Console.WriteLine();
        }
    }
}
