using System;

/*
 * @Task
 * Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
 * Use variable number of arguments.
 */
namespace _14.IntegerCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("minimum member of the set: " + GetMin(2,1,2,3,45,6,-2));
            Console.WriteLine("maximum member of the set: " + GetMax(2, 1, 2, 3, 45, 6, -2));
            Console.WriteLine("average of the set: " + GetAverage(1,2,3,4));
            Console.WriteLine("sum of the set: " + GetSum(2, 1, 2, 3, 45, 6, -2));
            Console.WriteLine("product of the set: " + GetProduct(2, 1, 2, 3, 45, 6, -2));
        }

        private static int GetMin(params int[] nums)
        {
            int min = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < min) min = nums[i];
            }

            return min;
        }

        private static int GetMax(params int[] nums)
        { 
            int max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max) max = nums[i];
            }

            return max;
        }

        private static double GetAverage(params int[] nums)
        {
            int sum = 0;

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
