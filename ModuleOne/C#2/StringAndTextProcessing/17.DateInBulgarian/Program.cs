using System;
using System.Threading;
using System.Globalization;
/*
 * @Task
 * 
 * Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the 
 * date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
 */
namespace _17.DateInBulgarian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("bg-BG");

            string format = "d.M.yyyy H:m:s";

            CultureInfo provider = CultureInfo.GetCultureInfo("BG-bg");
            
            Console.WriteLine("Enter date [dd.mm.YY hh:mm:ss]");

            string date = Console.ReadLine();

            DateTime time = DateTime.ParseExact(date, format, provider).AddHours(30).AddMinutes(30);

            Console.WriteLine(time.ToString("dd.MM.yyyy HH:mm:ss dddd"));

        }
    }
}
