using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwords
{
    class Program
    {
        static int n = 10;
        static int k = 10;

        static bool[] used = new bool[n];
        static int[] arr = new int[n];

        static List<int[]> needed = new List<int[]>();

        static void Main(string[] args)
        {
            GenerateVariationsNoReps(0);

          //  foreach (var item in needed)
        //    {
                //PrintVariations(item);
         //   }
        }

        static void GenerateVariationsNoReps(int index)
        {
            if (index >= k)
            {
                PrintVariations(arr);
              //  needed.Add(arr.Take(k).ToArray());
            }
            else
            {
                for (int i = 0; i < n; i++)
                    if (!used[i])
                    {
                        used[i] = true;
                        arr[index] = i;
                        GenerateVariationsNoReps(index + 1);
                        used[i] = false;
                    }
            }
        }

        private static void PrintVariations(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
