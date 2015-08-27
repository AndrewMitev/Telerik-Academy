using System;
using System.Linq;
using System.Net.Mail;
/*
 * @ Task
 * 
 * Write a program for extracting all email addresses from given text.
 * All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
 */
namespace _18.ExtractEmail
{
    class Program
    {
        private static readonly char[] separators = new char[] { ' ', '\t', ',', '!', '?', ':', ';', '(', ')', '{', '}', '[', ']' };

        static void Main(string[] args)
        {
            string sample = "some randome email is akon93@abv.bg and another random. ,! email is gergana@gmail.com!";

            string[] elements = sample.Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => isEmail(x))
                .ToArray();

            Console.WriteLine("Valid emails: " + String.Join(" ", elements));
        }

        private static bool isEmail(string mail)
        {
            try
            {
                MailAddress address = new MailAddress(mail);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
