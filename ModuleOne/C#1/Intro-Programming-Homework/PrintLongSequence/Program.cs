using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = -3;

            Console.Write(a + " " + b + " ");

            int counter = 499;
            while (counter != 0)
            {
                a += 2;
                b -= 2;
                Console.Write(a + " " + b + " ");
                counter--;
            }
            Console.WriteLine();
        }
    }
}
