namespace TellMeDayService
{
    using System;
    using System.Globalization;

    public class DateService : IDateService
    {
        public string TellMeTheDay(DateTime date)
        {
            CultureInfo culture = new CultureInfo("bg");

            return culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
        }
    }
}
