using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ModifyBit
{
    class Program
    {
        static void Main(string[] args)
        {
            uint result;
            Console.Write("Enter number:");
            uint n = UInt32.Parse(Console.ReadLine());

            Console.WriteLine("Enter bit index:");
            int p = UInt16.Parse(Console.ReadLine());

            Console.WriteLine("Enter new value for bit (0/1)");
            byte v = byte.Parse(Console.ReadLine());

            Console.WriteLine("Binary representation:\n {0}", Convert.ToString(n, 2).PadLeft(32, '0'));

            if (v == 0)
            {
                result =(uint) ~(1 << p) & n;
            }
            else 
            {
                result = (uint)(1 << p) | n;
            }
            Console.WriteLine("Binary result:\n {0}", Convert.ToString(result, 2).PadLeft(32, '0'));
            Console.WriteLine(result);
        }
    }
}
