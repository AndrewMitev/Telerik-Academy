using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Task:
 * You are given an array of strings. Write a method that sorts the
 * array by the length of its elements (the number of characters composing them).
 */
namespace _05.SortByStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "I", "could", "use", "some", "bonus", "points", "if", "you", "know", "what", "I", "mean", ":D" };

            SortThisBitch(array);

            Console.WriteLine(String.Join(" ", array));
        }

        public static void SortThisBitch(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].Length < array[j + 1].Length)
                    {
                        string swap = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = swap;
                    }
                }
            }
        }
    }
}
