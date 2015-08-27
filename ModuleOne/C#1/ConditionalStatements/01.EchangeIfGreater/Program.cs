using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * @Task
 * Write an if-statement that takes two double variables a and b and 
 * exchanges their values if the first one is greater than the second one. As a result print the values a and b, 
 * separated by a space.
 */
namespace _01.EchangeIfGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5.5;
            double b = 4.5;

            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;

                Console.WriteLine(a + " " + b);
            }
        }
    }
}
