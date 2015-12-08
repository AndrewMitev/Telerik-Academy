namespace _2.StackUsage
{
    using System.Collections.Generic;
    using Helpers;

    public class Startup
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            ConsoleTool.LoadStack(stack);

            while (stack.Count != 0)
            {
                System.Console.WriteLine(stack.Pop() + " ");
            }

            System.Console.WriteLine();
        }
    }
}
