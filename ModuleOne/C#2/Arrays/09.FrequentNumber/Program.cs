using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3,11, 11, 11 };
            int maxCount = 0, maxValue = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int temp = array[i];
                int tempCount = 0;

                for (int j = 0; j < array.Length; j++)
                {
                    if (temp == array[j])
                    {
                        tempCount++;
                    }
                }

                if (tempCount > maxCount)
                {
                    maxCount = tempCount;
                    maxValue = array[i];
                }
            }

            Console.WriteLine(maxValue + "({0} times)", maxCount);
        }
    }
}
