using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
 * Write a program that reads 3 numbers:
 * integer a (0 <= a <= 500)
 * floating-point b
 * floating-point c
 * The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
 * The number a should be printed in hexadecimal, left aligned
 * Then the number a should be printed in binary form, padded with zeroes
 * The number b should be printed with 2 digits after the decimal point, right aligned
 * The number c should be printed with 3 digits after the decimal point, left aligned.
 */
namespace _05.FormattingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            float b, c;

            Console.WriteLine("Enter a:");
            int.TryParse(Console.ReadLine(), out a);

            Console.WriteLine("Enter b and c:");
            float.TryParse(Console.ReadLine(), out b);
            float.TryParse(Console.ReadLine(), out c);

            Console.WriteLine((" " + a.ToString("X") + " |0" + Convert.ToString(a, 2) + "| " + "{0:0.00}|{1:0.000} |"), b, c);
        }
    }
}
