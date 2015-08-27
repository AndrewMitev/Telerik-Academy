using System;

/*
 * @ Task
 * Write a program that prints to the console which day of the week is today.
 */
namespace _03.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime day = DateTime.Now;
            
            Console.WriteLine("Today is " + day.DayOfWeek);
        }
    }
}
