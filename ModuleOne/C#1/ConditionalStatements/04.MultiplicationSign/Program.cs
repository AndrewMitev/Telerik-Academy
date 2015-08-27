using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.Write("Enter a:");
            double.TryParse(Console.ReadLine(), out a);

            Console.Write("Enter b:");
            double.TryParse(Console.ReadLine(), out b);

            Console.Write("Enter c:");
            double.TryParse(Console.ReadLine(), out c);

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
            }
            else if ((a < 0 && !(b < 0 || c < 0)) || (b < 0 && !(a < 0 || c < 0) || (c < 0 && !(a < 0 || b < 0))))
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        
        }
    }
}
