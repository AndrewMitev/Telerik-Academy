namespace _10.StrangeOperations
{
    using Helpers;
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            //int n = ConsoleTool.ReadInteger();
            //int m = ConsoleTool.ReadInteger();
            int n = 5;
            int m = 16;

            Queue<int> queue = new Queue<int>();

            while (n <= m)
            {
                queue.Enqueue(m);

                if (m / 2 >= n)
                {
                    if (m % 2 == 0)
                    {
                        m /= 2;
                    }
                    else
                    {
                        m--;
                    }
                }
                else
                {
                    if (m - 2 >= n)
                    {
                        m -= 2;
                    }
                    else
                    {
                        m--;
                    }
                }
            }

            Console.WriteLine(string.Join(",", queue.Reverse()));
        }
    }
}
