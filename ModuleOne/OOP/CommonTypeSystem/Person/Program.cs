using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person vanya = new Person("Vanya", 18);
            Person voldemort = new Person("Voldemort");

            Console.WriteLine(vanya);
            Console.WriteLine(voldemort);
        }
    }
}
