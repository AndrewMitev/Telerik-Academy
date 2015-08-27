using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
 * Find in the array a subset of K elements that have sum S or indicate about its absence.
 */
namespace _17.SubsetKSumS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N:");
            int N = int.Parse(Console.ReadLine());
            
            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
             
            Console.Write("S:");
            int S = int.Parse(Console.ReadLine());

            Console.Write("K:");
            int K = int.Parse(Console.ReadLine());

            

            for (int i = 0; i < array.Length; i++)
            {
                int counter = K;
                int sum = S;

                for (int j = i; j < N; j++)
                {
                    if (sum - array[j] >= 0 && counter >= 0)
                    {
                        int tempSum = sum;
                        sum -= array[j];
                        counter--;

                        if (sum == 0 && counter == 0)
                        {
                            Console.WriteLine("yes");
                            return;
                        }

                        if (counter == 0 && sum > 0)
                        {
                            sum = tempSum;
                        }
                    }
                }
            }

            Console.WriteLine("No combination found. I am so sorry for you!");
        }
    }
}
