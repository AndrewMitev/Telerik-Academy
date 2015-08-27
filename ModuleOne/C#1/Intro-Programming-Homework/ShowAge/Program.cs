using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowAge
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your birthday(DD/MM/YYYY):");
            string date = Console.ReadLine();
            DateTime birthDay;

            while (!DateTime.TryParse(date, out birthDay))
            {
                Console.WriteLine("Please enter valid date!");
                date = Console.ReadLine();
            }

            DateTime now = DateTime.Now;
            int age = now.Year - birthDay.Year;
            if (now < birthDay.AddYears(age)) 
            {
                age--;
            }

            Console.WriteLine("You are {0} years old! After 10 years you will be {1} years old.", age, age + 10);
        }
    }
}
