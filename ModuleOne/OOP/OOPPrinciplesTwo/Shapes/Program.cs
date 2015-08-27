using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Triangle(3.25, 4),
                new Rectangle(3, 2),
                new Square(4)
            };

            foreach (var item in shapes)
            {
                if (item.GetType() == typeof(Triangle))
                {
                    Console.Write("Triangle surface: ");
                }
                else if (item.GetType() == typeof(Rectangle))
                {
                    Console.Write("Rectangle surface: ");
                }
                else if (item.GetType() == typeof(Square))
                {
                    Console.Write("Square surface: ");
                }

                Console.Write(item.CalculateSurface() + "\n");
            }
        }
    }
}
