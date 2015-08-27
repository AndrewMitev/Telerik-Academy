using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExtractBitFromInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            uint n = UInt32.Parse(Console.ReadLine());

            Console.WriteLine("Enter bit index:");
            int p = UInt16.Parse(Console.ReadLine());

            Console.WriteLine("Binary representation:\n {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("Wanted bit is:" + ((n >> p) & 1));
        }
    }
}
