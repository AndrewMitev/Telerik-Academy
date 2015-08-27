namespace Cube
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Cube
    {
        public static void Main(string[] args)
        {
            int receivedNumber = int.Parse(Console.ReadLine());

            Console.Write(new string(' ', receivedNumber - 1));
            Console.Write(new string(':', receivedNumber));
            Console.WriteLine();

            Console.Write(new string(' ', receivedNumber - 2));
            Console.Write(':');
            Console.Write(new string('/', receivedNumber - 2));
            Console.Write("::");
            Console.WriteLine();

            for (int i = 1; i <= receivedNumber - 3; i++)
            {
                Console.Write(new string(' ', receivedNumber - i - 2));
                Console.Write(":");
                Console.Write(new string('/', receivedNumber - 2));
                Console.Write(":");
                Console.Write(new string('X', i));
                Console.Write(":");
                Console.WriteLine();
            }

            Console.Write(new string(':', receivedNumber));
            Console.Write(new string('X', receivedNumber - 2));
            Console.Write(":");
            Console.WriteLine();

            for (int i = receivedNumber - 3; i >= 1; i--)
            {
                Console.Write(":");
                Console.Write(new string(' ', receivedNumber - 2));
                Console.Write(":");
                Console.Write(new string('X', i));
                Console.Write(":");
                Console.WriteLine();
            }

            Console.Write(":");
            Console.Write(new string(' ', receivedNumber - 2));
            Console.WriteLine("::");
            Console.WriteLine(new string(':', receivedNumber));
        }
    }
}
