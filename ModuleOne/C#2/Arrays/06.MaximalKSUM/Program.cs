using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that reads two integer numbers N and K and an array of N elements from the console.
 * Find in the array those K elements that have maximal sum.
 */
namespace _06.MaximalKSUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, K;

            Console.Write("Elements:");
            int.TryParse(Console.ReadLine(), out N);

            Console.Write("K:");
            int.TryParse(Console.ReadLine(), out K);

            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j + 1] > array[j])
                    {
                        int swap = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = swap;
                    }
                }
            }

            if (N < K)
            {
                Console.WriteLine("Incorrect values");
                Environment.Exit(0);
            }

            Console.WriteLine("Searched numbers are:");
            for (int i = 0; i < K; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
