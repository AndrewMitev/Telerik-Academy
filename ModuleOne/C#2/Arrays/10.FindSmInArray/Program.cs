using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that finds in given array of integers a sequence of given sum S (if present).
 */
namespace _10.FindSmInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 3, 1, 4, 2, 5, 8 };

            Console.Write("S:");
            int S = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    for (int k = 0; k < array.Length; k++)
                    {
                        if ((array[i] + array[j] + array[k]) == S &&  i == j - 1 && i == k - 2 )
                        {
                            Console.WriteLine("{0},{1},{2}", array[i], array[j], array[k]);
                            Environment.Exit(0);
                        }
                    }
                }
            }

            Console.WriteLine("No combination found. I am so sorry for you!");
        }
    }
}
