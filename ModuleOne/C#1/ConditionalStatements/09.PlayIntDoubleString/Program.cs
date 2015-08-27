using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that, depending on the user’s choice, inputs an int, double or string variable.
 * If the variable is int or double, the program increases it by one.
 * If the variable is a string, the program appends * at the end.
 * Print the result at the console. Use switch statement.
 */
namespace _09.PlayIntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, choose a type");
            Console.WriteLine("1-->int");
            Console.WriteLine("2-->double");
            Console.WriteLine("3-->string");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    {
                        Console.WriteLine("Please enter int");
                        int num = int.Parse(Console.ReadLine());
                        Console.WriteLine(++num);
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Please enter double");
                        double num = double.Parse(Console.ReadLine());
                        Console.WriteLine(++num);
                        break;
                    }
                case "3":
                    { 
                        Console.WriteLine("Please, enter string");
                        string text = Console.ReadLine();
                        Console.WriteLine(text + "*");
                        break;
                    }
                default: Console.WriteLine("Invalid choice. Aborting program"); break;
            }

        }
    }
}
