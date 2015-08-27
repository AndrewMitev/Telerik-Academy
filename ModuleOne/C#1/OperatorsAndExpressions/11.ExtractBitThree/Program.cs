using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ExtractBitThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 3;
            Console.Write("Enter number:");

            uint n = UInt32.Parse(Console.ReadLine());
            Console.WriteLine("Binary representation:\n {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("Third bit is:" + ((n >> p) & 1));
        }
    }
}
