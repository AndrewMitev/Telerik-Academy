using System;
using System.Numerics;

namespace SaddyCopper
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());
            BigInteger product = new BigInteger(1);

            long sum;
            byte trans = 0;

            while (true)
            {
                while (num > 0)
                {
                    sum = 0;
                    num /= 10;
                    string snum = num.ToString();

                    for (int i = 0; i < snum.Length; i++)
                    {
                        if (i == 0 || i % 2 == 0)
                        {
                            sum += int.Parse(snum[i].ToString());
                        }
                    }

                    if (sum != 0)
                    {
                        product *= sum;
                    }
                }

                trans++;

                if (product / 10 == 0)
                {
                    Console.WriteLine(trans);
                    Console.WriteLine(product);
                    break;
                }

                if (trans == 10)
                {
                    Console.WriteLine(product);
                    break;
                }

                num = product;
                product = 1;

            }

            

        }
    }
}
