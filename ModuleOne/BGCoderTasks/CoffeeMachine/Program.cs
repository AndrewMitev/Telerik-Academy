using System;


namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            decimal A = decimal.Parse(Console.ReadLine());
            decimal P = decimal.Parse(Console.ReadLine());

            decimal available = (decimal)((a * 0.05) + (b * 0.1) + (c * 0.2) + (d * 0.5) + (e * 1));

            if (A - P < 0)
            {
                Console.WriteLine("More {0:0.00}",(decimal)((A - P) * - 1));
            }
            else if( A - P >= 0 && A - P <= available)
            {
                Console.WriteLine("Yes {0:0.00}", (decimal)(available - (A - P)) );
            }
            else if (A - P >= 0 && A - P > available)
            {
                Console.WriteLine("No {0:0.00}", (decimal)((A - P) - available));
            }
        }
    }
}
