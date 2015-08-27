using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CirclePerimeterArea
{
    class Program
    {
        static void Main(string[] args)
        {
            float radius;
            Console.Write("Enter radius:");
            float.TryParse(Console.ReadLine(), out radius);

            Console.WriteLine("Perimeter: {0:0.00} Area: {1:0.00}",(2 * Math.PI * radius), (Math.PI * Math.Pow(radius, 2)));
        }
    }
}
