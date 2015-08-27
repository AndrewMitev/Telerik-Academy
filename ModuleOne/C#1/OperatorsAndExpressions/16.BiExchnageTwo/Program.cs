using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * @ I've used StringBuilder and try-catch construction. If you're not familiar with them 
 * I apologise for the inconvenience, but you should check them.
 */
namespace _16.BiExchnageTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            uint n = 0;
            try
            {
                n = UInt32.Parse(Console.ReadLine());
            }
            catch(OverflowException)
            {
                Console.WriteLine("Out of range. Aborting program ..");
                Environment.Exit(0); 
            }

            Console.WriteLine("Binary representation of n:\n {0}", Convert.ToString(n, 2).PadLeft(32, '0'));

            Console.Write("Enter p:");
            byte p = byte.Parse(Console.ReadLine());
            Console.Write("Enter q:");
            byte q = byte.Parse(Console.ReadLine());
            Console.Write("Enter k:");
            byte k = byte.Parse(Console.ReadLine());

            if(p < 0 || p > 31 || q < 0 || q > 31 || 31 - (p + k - 1) < 0)
            {
                Console.WriteLine("Out of range. Aborting program ..");
                Environment.Exit(0);
            }
            
            string binary = "00000000000000000000000000000000";
            StringBuilder strMaskOne = new StringBuilder(binary); 
            StringBuilder strMaskTwo = new StringBuilder(binary);

            int begin = (binary.Length - 1 - p);
            int end = (binary.Length - 1) - (p + k - 1);
            int beginTwo = (binary.Length - 1 - q);
            int endTwo = (binary.Length - 1) - (q + k - 1);

            if (end < beginTwo || endTwo < begin)
            {
                Console.WriteLine("Overlapping. Aborting program ..");
                Environment.Exit(0);
            }

            for (int i = begin ; i >= end; i--)
            {
                strMaskOne[i] = '1'; 
            }

            for (int i = beginTwo; i >= endTwo; i--)
            {
                strMaskTwo[i] = '1';
            }

            uint firstMask = Convert.ToUInt32(strMaskOne.ToString(), 2);
            uint secondMask = Convert.ToUInt32(strMaskTwo.ToString(), 2);
            
            firstMask = n & firstMask;
            secondMask = n & secondMask;


            uint result = n & ~(firstMask | secondMask);
            int shiftage;

            if (firstMask < secondMask)
            {
                shiftage = q - p;
                result = result | (firstMask << shiftage);
                result = result | (secondMask >> shiftage);
                Console.WriteLine("Binary result:\n {0}", Convert.ToString(result, 2).PadLeft(32, '0'));
                Console.WriteLine("result:\n" + result);
            }
            else
            {
                shiftage = p - q;
                result = result | (firstMask >> shiftage);
                result = result | (secondMask << shiftage);
                Console.WriteLine("Binary result:\n {0}", Convert.ToString(result, 2).PadLeft(32, '0'));
                Console.WriteLine("result:\n" + result);
            }
        }
    }
}
