namespace Printing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Printing
    {
        public static void Main(string[] args)
        {
            int firstReceivedNumber = int.Parse(Console.ReadLine());
            int secondReceivedNumber = int.Parse(Console.ReadLine());

            double receivedDoubleNumber = double.Parse(Console.ReadLine());

            int totalPages = firstReceivedNumber * secondReceivedNumber;

            double neededRealms = (double)totalPages / 500;

            double money = neededRealms * receivedDoubleNumber;

            Console.WriteLine("{0:0.00}", money);
        }
    }
}
