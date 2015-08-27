using System;

/*
 * @Task
 * Extend the previous program to support also subtraction and multiplication of polynomials.
 */
namespace _12.SubtractingPolynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] polynomeOne = { 5, 0, 2, 7, 8 };
            int[] polynomeTwo = { 1, 0, 11 };

            int[] sum = AddTwoPolynoms(polynomeOne, polynomeTwo);

            Console.WriteLine("Add two polynome polynome:");
            PrintPolynome(sum);

            sum = SubtractTwoPolynoms(polynomeOne, polynomeTwo);
            Console.WriteLine("Subtract two polynome polynome:");
            PrintPolynome(sum);

            sum = MultiplyTwoPolynoms(polynomeOne, polynomeTwo);
            Console.WriteLine("Multiply two polynome polynome:");
            PrintPolynome(sum);
     
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

        private static int[] SubtractTwoPolynoms(int[] pOne, int[] pTwo)
        {
            if (pOne.Length < pTwo.Length)
            {
                int[] sum = new int[pTwo.Length];

                for (int i = 0; i < pTwo.Length; i++)
                {
                    if (i < pOne.Length)
                    {
                        sum[i] = pOne[i] - pTwo[i];
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
                        sum[i] = pOne[i] - pTwo[i];
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
                    sum[i] = pOne[i] - pTwo[i];
                }

                return sum;
            }
        }

        private static int[] MultiplyTwoPolynoms(int[] pOne, int[] pTwo)
        {
            if (pOne.Length < pTwo.Length)
            {
                int[] sum = new int[pTwo.Length];

                for (int i = 0; i < pTwo.Length; i++)
                {
                    if (i < pOne.Length)
                    {
                        sum[i] = pOne[i] * pTwo[i];
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
                        sum[i] = pOne[i] * pTwo[i];
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
                    sum[i] = pOne[i] * pTwo[i];
                }

                return sum;
            }
        }

        private static void PrintPolynome(int[] p)
        {
            for (int i = p.Length - 1; i >= 0; i--)
            {
                if (i != 0 && p[i] != 0)
                {
                    Console.Write("{0}x^{1} + ", p[i], i + 1);
                }
                else if (p[i] != 0)
                {
                    Console.Write("{0}", p[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
