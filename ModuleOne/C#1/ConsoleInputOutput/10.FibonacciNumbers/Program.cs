using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that reads a number n and prints on 
 * the console the first n members of the Fibonacci sequence
 * (at a single line, separated by comma and space - ,)
 */
namespace _10.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n;

            Console.Write("Enter n:");
            byte.TryParse(Console.ReadLine(), out n);

            int firstMember = 0, secondMember = 1, sum;

            if(n == 1)
            {
                Console.WriteLine("0");
            }

            else if (n == 2)
            {
                Console.WriteLine("0, 1");
            }
            else
            {
                Console.Write("{0}, {1},", firstMember, secondMember);

                for (byte i = 0; i < n - 2; i++)
                {
                    sum = firstMember;
                    firstMember = secondMember;
                    secondMember += sum;

                    Console.Write(" " + secondMember + ",");
                }
                Console.WriteLine();
            }
        }
    }
}
