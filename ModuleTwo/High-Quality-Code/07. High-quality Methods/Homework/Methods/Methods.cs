namespace Methods
{
    using System;

    internal class Methods
    {
        internal static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides of triangle must be positive numbers!");
            }

            double semiPerimiter = (a + b + c) / 2;
            double area = Math.Sqrt(semiPerimiter * (semiPerimiter - a) * (semiPerimiter - b) * (semiPerimiter - c));

            return area;
        }

        internal static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Please enter single digit.");
            }
        }

        internal static int FindMaximalElementInSequence(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("FindMax(): must pass parameters.");
            }

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[0])
                {
                    elements[0] = elements[i];
                }
            }

            return elements[0];
        }

        internal static void PrintAsNumber(object number, string format)
        {
            switch (format)
            {
                case "f":
                    {
                        Console.WriteLine("{0:f2}", number);
                        break;
                    }

                case "%":
                    {
                        Console.WriteLine("{0:p0}", number);
                        break;
                    }

                case "r":
                    {
                        Console.WriteLine("{0,8}", number);
                        break;
                    }

                default: throw new ArgumentException("PrintAsNumber(): format must be only f, %, r");
            }
        }

        internal static double CalculateDistance(
            double x1,
            double y1,
            double x2,
            double y2, 
            out bool isHorizontal,
            out bool isVertical)
        {
            isHorizontal = (y1 == y2);
            isVertical = (x1 == x2);

            double distanceBetweenXPoints = Math.Pow(x2 - x1, 2);
            double distanceBetweenYPoints = Math.Pow(y2 - y1, 2);

            double distance = Math.Sqrt(distanceBetweenXPoints + distanceBetweenYPoints);
            return distance;
        }

        internal static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));
            
            Console.WriteLine(NumberToDigit(5));
            
            Console.WriteLine(FindMaximalElementInSequence(5, -1, 3, 2, 14, 2, 3));
            
            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(CalculateDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            bool isOlder = peter.IsOlderThan(stella);
            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, isOlder);
        }
    }
}
