using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddOrEvenIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter number:");
            int.TryParse(Console.ReadLine(), out number);
            if (number % 2 == 0)
            {
                Console.WriteLine(false);
            }
            else 
            {
                Console.WriteLine(true);
            }
        }
    }
}
