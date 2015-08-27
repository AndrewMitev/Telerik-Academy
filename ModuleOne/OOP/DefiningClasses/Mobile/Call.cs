using System;
using System.Globalization;

namespace Mobile
{
    public class Call
    {
        private DateTime date;

        private DateTime time;

        private string dialledPhone;

        internal long? duration;

        public Call()
        { 
        
        }

        public Call(string date, string time, string dialled, long? dur)
        {
            try
            {
                this.date = DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                this.time = DateTime.ParseExact(time, "H:mm:ss", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong time data.");
            }

            this.dialledPhone = dialled;
            this.duration = dur;
        }

        public long? Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Date taken: {0}.{1}.{2} {3}:{4}:{5} \ndialed phone: {6}, Duration(in seconds): {7}", date.Day, date.Month, date.Year, time.Hour,time.Minute, time.Second, dialledPhone, duration);
        }
    }
}
