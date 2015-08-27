using System;

/*
 * @ Task
 * Write methods that calculate the surface of a triangle by given:
 * Side and an altitude to it;
 * Three sides;
 * Two sides and an angle between them;
 * Use System.Math
 */
namespace _04.TriangleSurface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateTriangleSurface(2, 2.13f));

            Console.WriteLine(CalculateTriangleSurface(2, 3, 6));

            Console.WriteLine(CalculateTriangleSurface(4, 7, 60d));

        }

        private static float CalculateTriangleSurface(float side, float altitude)
        {
            return (side * altitude) / 2;
        }

        private static float CalculateTriangleSurface(float sideOne, float sideTwo, float sideThree)
        {
            float p = (sideOne + sideTwo + sideThree) / 2;

            return (float)Math.Sqrt(p*(p - sideOne) * (p - sideTwo) * (p -sideThree));
        }

        private static double CalculateTriangleSurface(float sideOne, float sideTwo, double angle)
        {
            return (sideOne * sideTwo * (Math.Sin(angle)*Math.PI / 180)) / 2;
        }
    }
}
