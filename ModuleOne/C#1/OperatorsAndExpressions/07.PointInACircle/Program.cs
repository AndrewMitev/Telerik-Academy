using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PointInACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x and y (if decimal separate with comma)");
            float x;
            float y;
            float.TryParse(Console.ReadLine(), out x);
            float.TryParse(Console.ReadLine(), out y);
            int radius = 2;
            if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(radius, 2))
            {
                Console.WriteLine(true);
            }
            else 
            {
                Console.WriteLine(false);
            }
        }
    }
}
