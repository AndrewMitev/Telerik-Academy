using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool isPrime = true;
            int.TryParse(Console.ReadLine(), out number);
            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }
            Console.WriteLine(isPrime);
        }
    }
}
