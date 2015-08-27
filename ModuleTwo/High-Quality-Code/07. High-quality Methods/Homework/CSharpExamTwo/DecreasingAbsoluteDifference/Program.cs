namespace DecreasingAbsoluteDifference
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            int lengthOfOperations = int.Parse(Console.ReadLine());
            List<bool> list = new List<bool>();

            for (int i = 0; i < lengthOfOperations; i++)
            {
                long[] array = Console.ReadLine().Split(' ')
                    .Select(x => long.Parse(x))
                    .ToArray();

                List<long> listOfAbsoluteDiffrencesBetweenNeighbours = TakeListOfAbsoluteDiffrencesBetweenNeighbours(array);

                bool isListInDecreasingOrder = IsDecreasing(listOfAbsoluteDiffrencesBetweenNeighbours);

                list.Add(isListInDecreasingOrder);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        private static List<long> TakeListOfAbsoluteDiffrencesBetweenNeighbours(long[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("TakeListOfAbsoluteDiffrencesBetweenNeighbours(): must pass parameters.");
            }

            List<long> list = new List<long>();

            for (int i = 0; i < array.Length - 1; i++)
            {
                long max, min;

                if (array[i] > array[i + 1])
                {
                    max = array[i];
                    min = array[i + 1];
                }
                else
                {
                    max = array[i + 1];
                    min = array[i];
                }

                long diffrence = max - min;
                list.Add(diffrence);
            }

            return list;
        }

        private static bool IsDecreasing(List<long> list)
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentException("isDecreasing(): must pass parameters.");
            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] < list[i + 1])
                {
                    return false;
                }
                else
                {
                    if ((list[i] - list[i + 1]) != 0 && (list[i] - list[i + 1]) != 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
