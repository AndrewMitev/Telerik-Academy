using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * @Task
 * A company has name, address, phone number, fax number, web site and manager.
 * The manager has first name, last name, age and a phone number.
 * Write a program that reads the information about a company and its manager and prints it back on the console.
 */
namespace _02.CompanyInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();

            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();

            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Fax number: ");
            string faxNumber = Console.ReadLine();

            Console.Write("Web site: ");
            string webSite = Console.ReadLine();

            Console.Write("Manager first name: ");
            string mFirstName = Console.ReadLine();

            Console.Write("Manager last name: ");
            string mLastName = Console.ReadLine();

            Console.Write("Manager age: ");
            string mAge = Console.ReadLine();

            Console.Write("Manager phone: ");
            string mPhone = Console.ReadLine();

            companyName = (companyName == null) ? "(no info)" : companyName;
            companyAddress = (companyAddress == null) ? "(no info)" : companyAddress;
            phoneNumber = (phoneNumber == null) ? "(no info)" : phoneNumber;
            faxNumber = (faxNumber == null) ? "(no info)" : faxNumber;
            webSite = (webSite == null) ? "(no info)" : webSite;
            mFirstName = (mFirstName == null) ? "(no info)" : mFirstName;
            mLastName = (mLastName == null) ? "(no info)" : mLastName;
            mAge = (mAge == null) ? "(no info)" : mAge;
            mPhone = (mPhone == null) ? "(no info)" : mPhone;


            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Tel. +" + phoneNumber);
            Console.WriteLine("Fax: " + faxNumber);
            Console.WriteLine("Web site: " + webSite);
            Console.WriteLine("Manager: " + mFirstName + " (аге: " + mAge + 
                ", " + mPhone + ")");
        }
    }
}
