using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that reads a rectangular matrix of size
 * N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
 */
namespace _02.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = 
            {
                { 2,  7,  9,  1,  2},
                {-2,  3, 17, -1,  9},
                { 1,  9,  9,  1,  7},
                {11, -5, 20,  4, -2},
                { 2, 17, 91, 19,  22}
            };

            int bestSum = int.MinValue;
            int startX = 0, startY = 0;

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int currentSum =    matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                                        matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                                        matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        startX = i;
                        startY = j;
                    }
                }
            }

            for (int i = startX; i < startX + 3; i++)
            {
                for (int j = startY; j < startY + 3; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(2, ' ') + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
