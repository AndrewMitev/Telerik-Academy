using System;
using System.Numerics;
/*
 * Write a program to calculate n! for each n in the range [1..100].
 * Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
 */
namespace _08.NFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger result = new BigInteger(1);

            for (int i = 1; i < 101; i++)
            {
                result = calculate(result, i);
                Console.WriteLine("{0}! --> {1}", i, result);
            }
        }

        public static BigInteger calculate(BigInteger num, int multiply)
        {
            string sNum = num.ToString();
            BigInteger steps = 1;

            BigInteger result = new BigInteger();

            BigInteger[] array = new BigInteger[sNum.Length];

            for (int i = 0; i < sNum.Length; i++)
            {
                array[i] = int.Parse(sNum[i].ToString());
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                result += array[i] * multiply * steps;
                steps *= 10;
            }

            return result;

        }
    }
}
