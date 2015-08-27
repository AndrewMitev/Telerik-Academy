using System;

/*
 * @ Task
 * Write a program that reads a year from the console and checks whether it is a leap one.
 * Use System.DateTime.
 */
namespace _01.LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Year:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Is it leap year? " + DateTime.IsLeapYear(year));
        }
    }
}
