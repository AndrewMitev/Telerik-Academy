using System;
using System.Windows;

namespace _10.PointTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x and y (if decimal use \',\')");
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            float radius = 1.5f;

            if (Math.Pow((x-1), 2) + Math.Pow((y-1), 2) <= Math.Pow(radius, 2) && ((x < -1 || x > 5) || (y < -1 || y > 1)))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
