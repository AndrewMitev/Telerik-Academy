using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Write a program that reads two integer arrays from the console and compares them element by element.
 */
namespace CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arrayOne = new int[4];
            int [] arrayTwo = new int [4];

            bool flag = true;

            Console.WriteLine("Enter first array(4 elements)");

            for (int i = 0; i < arrayOne.Length; i++)
            {
                arrayOne[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter second array");

            for (int i = 0; i < arrayTwo.Length; i++)
            {
                arrayTwo[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Are they equal? ");

            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    flag = false;
                }
            }

            Console.WriteLine(flag);

        }
    }
}
