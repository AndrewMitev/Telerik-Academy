using System;
using System.Text;

/*
 * Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i]
 * contains a digit; the last digit is kept in arr[0]).
 * Each of the numbers that will be added could have up to 10 000 digits.
 */
namespace _08.NumberAsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 93810;
            string n = numOne.ToString();
            int numTwo = 63961;
            string t = numTwo.ToString();

            int[] numberOne =new int[numOne.ToString().Length];
            int[] numberTwo = new int[numTwo.ToString().Length];

            for (int i = 0; i < numberOne.Length; i++)
            {
               numberOne[i] = int.Parse(n[i].ToString());
            }

            for (int i = 0; i < numberTwo.Length; i++)
            {
                numberTwo[i] = int.Parse(t[i].ToString());
            }

            int[] sum = Sum(numberOne, numberTwo);

            Console.WriteLine(String.Join(" ", sum));
        }

        private static int[] Sum(int[] n1, int[] n2)
        {
            int[] temp = new int[n1.Length];
            int[] builderArray = new int[n1.Length + 1];
            int remaining = 0;
            StringBuilder builder = new StringBuilder();

            for (int i = n1.Length - 1; i >= 0; i--)
            {

                if (n1[i] + n2[i] > 9)
                {
                    int sum = n1[i] + n2[i];
                    temp[i] = sum % 10 + remaining;

                    remaining = sum / 10;

                    if (i == 0)
                    {
                        builder = new StringBuilder(remaining.ToString());
                        builder.Append(String.Join("", temp));
                    }
                }
                else 
                {
                    temp[i] = n1[i] + n2[i] + remaining;
                    remaining = 0;
                }
            }

            CheckBuilder(builderArray, builder);

            return builder.Length == 0 ? temp : builderArray;
        }

        public static void CheckBuilder(int[] builderArray, StringBuilder builder)
        {
            if (builder.Length == 0)
            {
                return;
            }

            for (int i = 0; i < builder.Length; i++)
            {
                builderArray[i] = int.Parse(builder[i].ToString());
            }
        }
    }
}
