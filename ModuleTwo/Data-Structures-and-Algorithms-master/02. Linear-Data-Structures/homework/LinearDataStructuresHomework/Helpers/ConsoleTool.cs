namespace Helpers
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public static class ConsoleTool
    {
        public static ICollection<int> LoadSequence(ICollection<int> dataList)
        {
            Console.WriteLine("Enter positive numbers. End operation with empty line.");

            while (true)
            {
                int number;
                if (int.TryParse(Console.ReadLine(), out number) && number > 0)
                {
                    dataList.Add(number);
                }
                else
                {
                    Console.WriteLine("Exit.");
                    break;
                }
            }

            return dataList;
        }

        public static Stack<int> LoadStack(Stack<int> dataList)
        {
            Console.WriteLine("Enter positive numbers. End operation with empty line.");

            while (true)
            {
                int number;
                if (int.TryParse(Console.ReadLine(), out number) && number > 0)
                {
                    dataList.Push(number);
                }
                else
                {
                    Console.WriteLine("Exit.");
                    break;
                }
            }

            return dataList;
        }

        public static void DisplayDictionaryForTaskSeven(Dictionary<int, int> dictionary)
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} --> {1} times.", item.Key, item.Value);
            }
        }

        public static int ReadInteger()
        {
            Console.WriteLine("Enter number: ");
            int number;
            int.TryParse(Console.ReadLine(), out number);

            return number;
        }
    }
}
