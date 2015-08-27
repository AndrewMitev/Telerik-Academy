using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * @Task:
 * Write a program that reads two positive integer numbers and prints how many numbers p exist 
 * between them such that the reminder of the division by 5 is 0.
 */
namespace _11.NumbersInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, end, p = 0;

            Console.Write("start = ");
            int.TryParse(Console.ReadLine(), out start);

            Console.Write("end = ");
            int.TryParse(Console.ReadLine(), out end);

            if(end < start)
            {
                Console.WriteLine("Invalid input, end must be bigger than start.");
                Environment.Exit(0);
            }

            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                    p++;
                }
            }

            Console.WriteLine("p = {0}", p);
            
        }
    }
}
