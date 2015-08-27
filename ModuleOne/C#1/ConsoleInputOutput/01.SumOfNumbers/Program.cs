using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Enter number:");
            int.TryParse(Console.ReadLine(), out a);

            Console.Write("Enter number:");
            int.TryParse(Console.ReadLine(), out b);

            Console.Write("Enter number:");
            int.TryParse(Console.ReadLine(), out c);

            Console.WriteLine("Their sum is {0}", (a + b +c));
        }
    }
}
