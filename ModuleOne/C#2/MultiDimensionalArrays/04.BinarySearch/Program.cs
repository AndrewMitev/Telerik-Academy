using System;

/*
 * Task:
 * Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method
 * Array.BinSearch() finds the largest number in the array which is ≤ K.
 */
namespace _04.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("K = ");
            int K = int.Parse(Console.ReadLine());

            int[] array = new int[N + 1];

            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            array[N] = K;
            Array.Sort(array);

            //find position of K and decrease to find the wanted element
            int position = Array.BinarySearch(array, K) - 1;

            if (position == 0)
            {
                Console.WriteLine("There is no such element");
                return;
            }
            
            Console.WriteLine("Largest number next to {0} is " + array[position], K);
        }
    }
}
