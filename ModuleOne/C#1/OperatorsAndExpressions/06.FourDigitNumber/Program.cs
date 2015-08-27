using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FourDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter number:");
            int.TryParse(Console.ReadLine(), out number);
            if (number < 1000 || number > 9999)
            {
                Console.WriteLine("Enter four digit number please.");
                Environment.Exit(0);
            }
            int sum = (number % 10) + ((number / 10) % 10) + ((number / 100) % 10) + (number / 1000);
            Console.WriteLine("Sum of digits is {0}", sum);
            Console.Write((number % 10) + "" + ((number / 10) % 10) + "" + ((number / 100) % 10) + "" + (number / 1000) + "\n");
            Console.Write((number % 10) + "" + (number / 1000) + "" + ((number / 100) % 10) + "" + ((number / 10) % 10) + "\n");
            Console.Write((number / 1000) + "" + ((number / 10) % 10) + "" + ((number / 100) % 10) + "" + (number % 10) + "\n");
        } 
    }
}
