using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Write a program that finds the maximal sequence of equal elements in an array.
 */
namespace _04.MaximalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1,3 , 3 , 3 , 3, 3 };

            int maxCounter = 0, maxValue = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int tempCounter = 1;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
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
                    maxValue = array[i];
                }
            }


            for (int i = 0; i < maxCounter; i++)
            {
                if (i != maxCounter - 1)
                {
                    Console.Write("{0},", maxValue);
                }
                else 
                {
                    Console.Write(maxValue);
                }
            }

            Console.WriteLine();
        }
    }
}
