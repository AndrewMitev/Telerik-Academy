using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.BitsExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            uint n = UInt32.Parse(Console.ReadLine());

            Console.WriteLine("Binary representation of n:\n {0}", Convert.ToString(n, 2).PadLeft(32, '0'));

            uint secondMask = 117440512u;
            uint firstMask = 56u;

            firstMask = n & firstMask;
            secondMask = n & secondMask;

            uint result = n & ~(firstMask | secondMask);
            result = result | (firstMask << 21);
            result = result | (secondMask >> 21);
            Console.WriteLine("Binary result:\n {0}", Convert.ToString(result, 2).PadLeft(32, '0'));
            Console.WriteLine("result:\n" + result);
        }
    }
}
