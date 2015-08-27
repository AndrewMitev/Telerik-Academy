using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
 */
namespace _15.PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, temp = 0;

            List<int> list = new List<int>();

            Console.Write("Enter limit:");
            int.TryParse(Console.ReadLine(), out n);

            for (int i = 2; i <= n; i++)
            {
                list.Add(i);
            }


            for (int i = 0; i < list.Count; i++)
            {
                temp = list[i];


                while (temp < n)
                {
                    temp += list[i];
                    list.Remove(temp);
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
               Console.WriteLine(list[i]);
            }
        }
    }
}
