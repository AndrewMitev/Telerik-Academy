using System;
using System.Collections.Generic;

/*
 * @Task
 * Write a method that calculates the number of workdays between today and given date, passed as parameter.
 * Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
 */
namespace _05.Workdays
{
    class Workdays
    {
        static void Main(string[] args)
        {

            int year, month, day;
            Console.Write("Enter Year: ");
            int.TryParse(Console.ReadLine(), out year);

            Console.Write("Enter Month: ");
            int.TryParse(Console.ReadLine(), out month);
            
            Console.Write("Enter Day: ");
            int.TryParse(Console.ReadLine(), out day);

            List<DateTime> holidays = new List<DateTime>() 
            {
                new DateTime(year, 1, 1),
                new DateTime(year, 3, 3),
                new DateTime(year, 5, 1),
                new DateTime(year, 5, 6),
                new DateTime(year, 5, 24), 
                new DateTime(year, 9, 6),
                new DateTime(year, 9, 22), 
                new DateTime(year, 11, 1),
                new DateTime(year, 12, 24), 
                new DateTime(year, 5, 25),
                new DateTime(year, 5, 26)
            };
            DateTime time = new DateTime(year, month, day);

            DateTime now = DateTime.Now;

            if (time < now)
            {
                Console.WriteLine("Enter future date please.");
                return;
            }

            TimeSpan span = time.Subtract(now);
            int days = span.Days;

            for (int i = 0; i < span.Days; i++)
            {
                if (now.AddDays(i).DayOfWeek == DayOfWeek.Saturday || now.AddDays(i).DayOfWeek == DayOfWeek.Sunday)
                {
                    days--;
                }

                for (int j = 0; j < holidays.Count; j++)
                {
                    if (now.AddDays(i) == holidays[j])
                    {
                        days--;
                    }
                }
            }

            Console.WriteLine("Workdays left: " + days);
            
        }
    }
}
