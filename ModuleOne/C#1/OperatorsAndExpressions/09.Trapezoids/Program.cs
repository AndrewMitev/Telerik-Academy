using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, h;
            Console.WriteLine("Enter a, b, h");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            h = float.Parse(Console.ReadLine());
            Console.WriteLine("Area is:" + ( ((a+b)/2)*h) );
        }
    }
}
