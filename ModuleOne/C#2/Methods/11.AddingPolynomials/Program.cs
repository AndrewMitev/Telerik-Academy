using System;

/*
 * @Task
 * Write a method that adds two polynomials.
 * Represent them as arrays of their coefficients.
 */
namespace _11.AddingPolynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] polynomeOne = { 5, 0, 2, 7, 8};
            int[] polynomeTwo = { 1, 0, 11};

            int[] sum = AddTwoPolynoms(polynomeOne, polynomeTwo);

            Console.WriteLine("Resulted polynome:");

            for (int i = sum.Length - 1; i >= 0; i--)
            {
                if (i != 0 && sum[i] != 0)
                {
                    Console.Write("{0}x^{1} + ", sum[i], i + 1);
                }
                else if(sum[i] != 0)
                {
                    Console.Write("{0}", sum[i]);
                }
            }
            Console.WriteLine();
        }

        private static int[] AddTwoPolynoms(int[] pOne, int[] pTwo)
        {
            if (pOne.Length < pTwo.Length)
            {
                int[] sum = new int[pTwo.Length];

                for (int i = 0; i < pTwo.Length; i++)
                {
                    if (i < pOne.Length)
                    {
                        sum[i] = pOne[i] + pTwo[i];
                    }
                    else
                    {
                        sum[i] = pTwo[i];
                    }
                }

                return sum;
            }
            else if (pOne.Length > pTwo.Length)
            {
                int[] sum = new int[pOne.Length];

                for (int i = 0; i < pOne.Length; i++)
                {
                    if (i < pTwo.Length)
                    {
                        sum[i] = pOne[i] + pTwo[i];
                    }
                    else
                    {
                        sum[i] = pOne[i];
                    }
                }

                return sum;
            }
            else
            { 
                int[] sum = new int[pOne.Length];

                for (int i = 0; i < pOne.Length; i++)
                {
                    sum[i] = pOne[i] + pTwo[i];
                }

                return sum;
            }
        }
    }
}
