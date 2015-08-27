using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DivideBySevenAndFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter number:");
            int.TryParse(Console.ReadLine(),out number);
            if (number % 7 == 0 && number % 5 == 0)
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
