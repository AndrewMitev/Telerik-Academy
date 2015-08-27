using System;
using System.Globalization;
using System.Threading;
using System.Linq;

/*
 * @ Task
 * 
 * Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
 * Display them in the standard date format for Canada.
 */
namespace _19.DatesCanada
{
    class Program
    {
        private static CultureInfo provider = CultureInfo.GetCultureInfo("en-CA");
        private static string format = "dd.MM.yyyy";

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Thread.CurrentThread.CurrentCulture =  new CultureInfo("en-CA");
            
            string text = "There is this date 21.03.2088 where some 23.424.44sd but this is true 19.09.2018.";

            text = text.Remove(text.Length - 1);

            DisplayDatesFromString(text, provider, format);
                     
        }

        private static void DisplayDatesFromString(string text, CultureInfo provider, string format)
        {
            string[] elements = text.Split(' ');

            foreach (string element in elements)
            {
                if (isDate(element))
                {
                    Console.WriteLine(String.Format("{0}", DateTime.ParseExact(element, format, provider)));
                }
            }         
        }

        private static bool isDate(string element)
        {
            try
            {
                DateTime time = DateTime.ParseExact(element, format, provider);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
