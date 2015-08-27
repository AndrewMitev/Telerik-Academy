using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of 
 * several neighbour elements located on the same line, column or diagonal.
 * Write a program that finds the longest sequence of equal strings in the matrix.
 * 
 */
namespace _03.SequenceNMatrix
{
    class Program
    {
        private static int counter = 0;
        private static string text;

        static void Main(string[] args)
        {
            //I am using recursion. It is working excellent!
            string[,] matrix = { 

                            {"ha", "fifi", "ho", "hi"},
                            {"fo", "ha", "hi", "xx"},
                            {"xxx", "ho", "ha", "xx"}

                            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    CheckRight(matrix, i, j, 1);
                    CheckDown(matrix, i, j, 1);
                    CheckMainDiagonal(matrix, i, j, 1);
                    CheckBackDiagonal(matrix, i, j, 1);
                }
            }
            
            for (int i = 0; i < counter; i++)
            {
                Console.Write(text + " ");
            }

            Console.WriteLine();
        }


        public static void CheckNeighbours(string[,] matrix, int indexX, int indexY)
        {
            int tempCounter = 1;

            CheckRight(matrix, indexX, indexY, tempCounter);
            CheckDown(matrix, indexX, indexY, tempCounter);
            CheckLeft(matrix, indexX, indexY, tempCounter);
            CheckUp(matrix, indexX, indexY, tempCounter);

        }

        public static bool CheckRight(string[,] matrix, int indexX, int indexY, int tempCounter) 
        {
            if (indexY + 1 < matrix.GetLength(1) && matrix[indexX, indexY + 1].Equals(matrix[indexX, indexY]))
            {
                tempCounter++;
                CheckRight(matrix, indexX, indexY + 1, tempCounter);
            }

            if (tempCounter > counter)
            {
                counter = tempCounter;
                text = matrix[indexX, indexY];
            }

            return false;
        }
        public static bool CheckDown(string[,] matrix, int indexX, int indexY, int tempCounter)
        {
            if (indexX + 1 < matrix.GetLength(0) && matrix[indexX + 1, indexY].Equals(matrix[indexX, indexY]))
            {
                tempCounter++;
                CheckDown(matrix, indexX + 1, indexY, tempCounter);
            }

            if (tempCounter > counter)
            {
                counter = tempCounter;
                text = matrix[indexX, indexY];
            }

            return false;
        }
        public static bool CheckLeft(string[,] matrix, int indexX, int indexY, int tempCounter)
        {
            if (indexY - 1 >= 0 && matrix[indexX, indexY - 1].Equals(matrix[indexX, indexY]))
            {
                tempCounter++;
                CheckLeft(matrix, indexX, indexY - 1, tempCounter);
            }

            if (tempCounter > counter)
            {
                counter = tempCounter;
                text = matrix[indexX, indexY];
            }

            return false;
        }
        public static bool CheckUp(string[,] matrix, int indexX, int indexY, int tempCounter)
        {
            if (indexX - 1 >= 0 && matrix[indexX - 1, indexY].Equals(matrix[indexX, indexY]))
            {
                tempCounter++;
                CheckUp(matrix, indexX - 1, indexY, tempCounter);
            }

            if (tempCounter > counter)
            {
                counter = tempCounter;
                text = matrix[indexX, indexY];
            }

            return false;
        }

        public static bool CheckMainDiagonal(string[,] matrix, int indexX, int indexY, int tempCounter)
        {
            if (indexX + 1 < matrix.GetLength(0) && indexY + 1 < matrix.GetLength(1) && matrix[indexX + 1, indexY + 1].Equals(matrix[indexX, indexY]))
            {
                tempCounter++;
                CheckMainDiagonal(matrix, indexX + 1, indexY + 1, tempCounter);
            }

            if (tempCounter > counter)
            {
                counter = tempCounter;
                text = matrix[indexX, indexY];
            }

            return false;
        }

        public static bool CheckBackDiagonal(string[,] matrix, int indexX, int indexY, int tempCounter)
        {
            if (indexX + 1 < matrix.GetLength(0) && indexY - 1 >= 0 && matrix[indexX + 1, indexY - 1].Equals(matrix[indexX, indexY]))
            {
                tempCounter++;
                CheckBackDiagonal(matrix, indexX + 1, indexY - 1, tempCounter);
            }

            if (tempCounter > counter)
            {
                counter = tempCounter;
                text = matrix[indexX, indexY];
            }

            return false;
        }
    }
}
