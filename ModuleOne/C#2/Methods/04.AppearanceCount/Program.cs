using System;

/*
 * Write a method that counts how many times given number appears in given array.
 * Write a test program to check if the method is workings correctly.
 */
namespace _04.AppearanceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3,2,3,4,5,67,6,4,5,6,75,535,452,3,25,64,6,6,3,1};

            Console.Write("Enter Number:");
            int times = CountNumber(array, int.Parse(Console.ReadLine()));
            Console.WriteLine(times + " times");
        }

        private static int CountNumber(int[] arr, int p)
        {
            int counter = 0;

            foreach (var num in arr)
            {
                if (num == p)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
