namespace _9.PrintFirstFiftyNumbersOfStupidSequnece
{
    using System.Collections.Generic;
    using Helpers;

    public class Startup
    {
        public static void Main()
        {
            int initialNumber = ConsoleTool.ReadInteger();

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(initialNumber);

            for (int i = 0; i < 50; i++)
            {
                int peeked = queue.Peek();

                int firstFollow = peeked + 1;
                int secondFollow = (2 * peeked) + 1;
                int thirdFollow = peeked + 2;

                queue.Enqueue(firstFollow);
                queue.Enqueue(secondFollow);
                queue.Enqueue(thirdFollow);

                System.Console.Write(queue.Dequeue() + " ");
            }

            System.Console.WriteLine();
        }
    }
}
