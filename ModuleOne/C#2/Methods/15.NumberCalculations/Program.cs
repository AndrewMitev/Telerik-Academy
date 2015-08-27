using System;
using System.Collections.Generic;
/*
 * @Task
 * Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
 * Use generic method (read in Internet about generic methods in C#).
 */
namespace _15.NumberCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("minimum member of the set: " + GetMin(2, 1, 2, 3, 45, 6, -2));
            Console.WriteLine("maximum member of the set: " + GetMax(2, 1, 2, 3, 45, 6, -2));
            Console.WriteLine("average of the set: " + GetAverage(3,3,4));
            Console.WriteLine("sum of the set: " + GetSum(2, 1, 2, 3, 45, 6, -2));
            Console.WriteLine("product of the set: " + GetProduct(2, 1, 2, 3, 45, 6, -2));
        }

        private static T GetMin<T>(params T[] nums) where T : System.IComparable<T>
        {
            T min = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i].CompareTo(min) == -1) min = nums[i];
            }

            return min;
        }

        private static T GetMax<T>(params T[] nums) where T : System.IComparable<T>
        {
            T max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i].CompareTo(max) == 1) max = nums[i];
            }

            return max;
        }

        private static double GetAverage<T>(params T[] nums)
        {
            dynamic sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            return (double)sum / nums.Length;
        }

        private static int GetSum(params int[] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            return sum;
        }

        private static int GetProduct(params int[] nums)
        {
            int product = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                product *= nums[i];
            }

            return product;
        }
    }
}
