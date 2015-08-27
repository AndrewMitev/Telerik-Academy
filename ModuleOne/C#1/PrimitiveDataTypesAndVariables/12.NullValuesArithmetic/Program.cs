using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NullValuesArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? number = null;
            double? dNumber = null;
            Console.WriteLine("{0} {1}", number, dNumber);
            number += 2;
            dNumber += null;
            Console.WriteLine("{0} {1}", number, dNumber);
        }
    }
}
