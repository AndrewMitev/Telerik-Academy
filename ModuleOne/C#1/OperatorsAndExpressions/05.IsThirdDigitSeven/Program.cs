using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.IsThirdDigitSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter number:");
            int.TryParse(Console.ReadLine(), out number);
            if ((number / 100) % 10 == 7)
            {
                Console.WriteLine(true);
            }
            else 
            {
                Console.WriteLine(false);
            }
        }
    }
}
