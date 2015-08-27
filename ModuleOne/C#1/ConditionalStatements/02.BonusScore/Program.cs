using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort score;

            Console.Write("Enter score:");
            ushort.TryParse(Console.ReadLine(), out score);

            switch(score)
            {
                case 1:
                case 2:
                case 3: score *= 10; break;
                case 4:
                case 5:
                case 6: score *= 100; break;
                case 7: 
                case 8:
                case 9: score *= 1000; break;
                default: Console.WriteLine("Invalid score!"); break;
            }
            Console.WriteLine(score);
        }
    }
}
