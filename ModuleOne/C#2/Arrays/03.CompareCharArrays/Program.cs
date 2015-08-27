using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that compares two char arrays lexicographically (letter by letter)
 */
namespace _03.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = {'a', 'n', 'd', 'y'};
            char[] secondArr = {'d', 'i', 'c', 'k'};

            bool equal = true;

            if (arr.Length != secondArr.Length)
            {
                equal = false;
            }

            else 
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != secondArr[i])
                    {
                        equal = false;
                    }
                }
            }

            Console.WriteLine("Are they the same? " + equal);


        }
    }
}
