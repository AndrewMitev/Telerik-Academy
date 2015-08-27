using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string firstName = "Andrey";
            string lastName = "Mitev";
            byte age = 21;
            bool isFemale = false;
            ulong id = 8123567890u;
            int employeeNumber = rand.Next(10000) + 27560000;
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}",firstName, lastName, age, isFemale, id, employeeNumber);

        }
    }
}
