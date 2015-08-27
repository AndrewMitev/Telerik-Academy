using System;

namespace RangeExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            ThrowDates();
        }

        private static void ThrowInts()
        {
            throw new InvalidRangeException<int>("Invalid parameters!", 3, 100);            
        }

        private static void ThrowDates()
        {
            throw new InvalidRangeException<DateTime>("Invalid date interval !", new DateTime(1988, 1, 1), DateTime.Now);            
        }

    }
}
