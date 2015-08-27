using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Task
 * Write a program that finds the largest area of equal neighbour
 * elements in a rectangular matrix and prints its size.
 * 
 * @Comment: Using recursion again
 */
namespace _07.LargestAreaInMatrix
{
    class Program
    {
        private static int counter = 0;
        private static int number;

        static void Main(string[] args)
        {
            int[,] matrix = { 

                         {1, 3,	2, 2, 2, 4},
                         {3, 3, 3, 2, 4, 4},
                         {4, 3, 1, 2, 3, 3},
                         {4, 3, 1, 3, 3, 1},
                         {4, 3, 3, 3, 1, 1}

                            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    CheckNeighbours(matrix, i, j);
                }
            }
            Console.WriteLine(counter + " times number " + number);

        }


        public static void CheckNeighbours(int[,] matrix, int indexX, int indexY)
        {
            int tempCounter = 1;

            CheckRight(matrix, indexX, indexY, ref tempCounter);
            CheckDown(matrix, indexX, indexY, ref tempCounter);
            CheckLeft(matrix, indexX, indexY, ref tempCounter);
            CheckUp(matrix, indexX, indexY, ref tempCounter);

        }

        public static void CheckNeighboursExceptLeft(int[,] matrix, int indexX, int indexY, ref int tempCounter)
        {
            CheckRight(matrix, indexX, indexY, ref tempCounter);
            CheckDown(matrix, indexX, indexY, ref tempCounter);
            CheckUp(matrix, indexX, indexY, ref tempCounter);
            
        }

        public static void CheckNeighboursExceptUp(int[,] matrix, int indexX, int indexY, ref int tempCounter)
        {
            CheckRight(matrix, indexX, indexY, ref tempCounter);
            CheckDown(matrix, indexX, indexY, ref tempCounter);
            CheckLeft(matrix, indexX, indexY, ref tempCounter);

        }

        public static void CheckNeighboursExceptRight(int[,] matrix, int indexX, int indexY, ref int tempCounter)
        {
            CheckUp(matrix, indexX, indexY, ref tempCounter);
            CheckDown(matrix, indexX, indexY, ref tempCounter);
            CheckLeft(matrix, indexX, indexY, ref tempCounter);

        }

        public static void CheckNeighboursExceptDown(int[,] matrix, int indexX, int indexY, ref int tempCounter)
        {
            CheckUp(matrix, indexX, indexY, ref tempCounter);
            CheckRight(matrix, indexX, indexY, ref tempCounter);
            CheckLeft(matrix, indexX, indexY, ref tempCounter);

        }



        public static bool CheckRight(int[,] matrix, int indexX, int indexY, ref int tempCounter)
        {
            if (indexY + 1 < matrix.GetLength(1) && matrix[indexX, indexY + 1].Equals(matrix[indexX, indexY]))
            {
                tempCounter++;
                CheckNeighboursExceptLeft(matrix, indexX, indexY + 1, ref tempCounter);
            }

            if (tempCounter > counter)
            {
                counter = tempCounter;
                number = matrix[indexX, indexY];
            }

            return false;
        }
        public static bool CheckDown(int[,] matrix, int indexX, int indexY, ref int tempCounter)
        {
            if (indexX + 1 < matrix.GetLength(0) && matrix[indexX + 1, indexY].Equals(matrix[indexX, indexY]))
            {
                tempCounter++;
                CheckNeighboursExceptUp(matrix, indexX + 1, indexY, ref tempCounter);

            }

            if (tempCounter > counter)
            {
                counter = tempCounter;
                number = matrix[indexX, indexY];
            }

            return false;
        }
        public static bool CheckLeft(int[,] matrix, int indexX, int indexY,ref int tempCounter)
        {
            if (indexY - 1 >= 0 && matrix[indexX, indexY - 1].Equals(matrix[indexX, indexY]))
            {
                tempCounter++;
                CheckNeighboursExceptRight(matrix, indexX, indexY - 1, ref tempCounter);
            }

            if (tempCounter > counter)
            {
                counter = tempCounter;
                number = matrix[indexX, indexY];
            }

            return false;
        }
        public static bool CheckUp(int[,] matrix, int indexX, int indexY,ref int tempCounter)
        {
            if (indexX - 1 >= 0 && matrix[indexX - 1, indexY].Equals(matrix[indexX, indexY]))
            {
                tempCounter++;
                CheckNeighboursExceptDown(matrix, indexX - 1, indexY, ref tempCounter);
            }

            if (tempCounter > counter)
            {
                counter = tempCounter;
                number = matrix[indexX, indexY];
            }

            return false;
        }
    }
}
