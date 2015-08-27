using System;

/*
 * @ Task
 * Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in 
 * scientific notation.
 * Format the output aligned right in 15 symbols.
 */
namespace _11.FormatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Format("{0,15:D} -> Decimal\n{0,15:X} -> Hexadecimal\n{0,15:P} -> Percentage\n{0,15:E} -> Scientific notation", num, num, num, num));
        }
    }
}
