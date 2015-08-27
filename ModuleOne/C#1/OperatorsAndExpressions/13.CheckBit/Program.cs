using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CheckBit
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            Console.Write("Enter number:");
            uint n = UInt32.Parse(Console.ReadLine());

            Console.WriteLine("Enter bit index:");
            int p = UInt16.Parse(Console.ReadLine());

            Console.WriteLine("Binary representation:\n {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
            if (((n >> p) & 1) == 1)
            {
                flag = true;
            }
            else 
            {
                flag = false;
            }
            Console.WriteLine("bit @ p = {0} \n {1}", p, flag);
        }
    }
}
