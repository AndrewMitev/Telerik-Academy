using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("bg");

            Console.WriteLine(culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek));
        }
    }
}
