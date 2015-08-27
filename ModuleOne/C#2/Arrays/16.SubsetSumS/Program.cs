using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * We are given an array of integers and a number S.
 * Write a program to find if there exists a subset of the elements of the array that has a sum S.
 */
namespace _16.SubsetSumS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 1, 2, 4, 3, 5, 2, 6 };

            Console.Write("S:");
            int S = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    for (int k = 0; k < array.Length; k++)
                    {
                        if ((array[i] + array[j] + array[k]) == S && 
                            i != j && i != k &&
                            j != k)
                        {
                            Console.WriteLine("yes");
                            Environment.Exit(0);
                        }
                    }
                }
            }

            Console.WriteLine("No combination found. I am so sorry for you!");
        }
    }
}
