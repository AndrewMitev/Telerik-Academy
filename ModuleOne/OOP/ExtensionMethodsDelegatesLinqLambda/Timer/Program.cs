using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(2);
            timer.AllMethods += SaySomething;
            timer.AllMethods += ILoveYou;

            timer.ExecuteMethods();
        }

        private static void SaySomething()
        {
            Console.WriteLine("Say something!");
        }

        private static void ILoveYou()
        {
            Console.WriteLine("I Love You!");
        }
    }
}
