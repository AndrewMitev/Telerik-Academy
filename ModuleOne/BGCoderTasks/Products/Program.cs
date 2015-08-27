using System;
using System.Numerics;
using System.Collections.Generic;


namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            List<int> list = new List<int>();
            List<int> secondList = new List<int>();

            BigInteger product = new BigInteger(1);
            BigInteger secondProduct = new BigInteger(1);

            int counter = 0;

            while (!input.Equals("END"))
            {
                input = Console.ReadLine();

                counter++;

                if (!input.Equals("END") && counter < 10)
                {
                    list.Add(int.Parse(input));
                }

                if (!input.Equals("END") && counter >= 10)
                {
                    secondList.Add(int.Parse(input));
                }
            }

            product = cal(list, product);

           // Console.WriteLine(product);

            if (counter >= 10)
            {
                secondProduct = cal(secondList, secondProduct);
             //   Console.WriteLine(secondProduct);
            }
        }

        public static BigInteger cal(List<int> list, BigInteger product)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
                if (i % 2 != 0)
                {
                    string sNum = list[i].ToString();
                    long temp = 1;

                    for (int j = 0; j < sNum.Length; j++)
                    {
                        if (sNum[j] != '0')
                        {
                            temp *= long.Parse(sNum[j].ToString());
                        }
                    }

                    product *= temp;
                }
            }

            Console.WriteLine("svurshva");
            return product;
        }
    }
}
