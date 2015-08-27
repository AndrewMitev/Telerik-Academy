using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            printA();
            printB();
            printC();
            printD();
        }

        static void printA()
        {
            Console.Write("Enter the size ot the matrix : ");
            int size = int.Parse(Console.ReadLine());

            int k = 1;
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[j, i] = k++;
                }
            }

            printMatrix(matrix);

        }

        public static void printB()
        {
            Console.Write("Enter the size ot the matrix : ");
            int size = int.Parse(Console.ReadLine());

            int k = 1;
            int[,] matrix = new int[size, size];
            int temp = 0;

            for (int i = 0; i < size; i++)
            {

                if (i % 2 != 0)
                {
                    temp = k + size - 1;
                    k = temp;
                }
                else
                {
                    k = temp + 1;
                }

                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i % 2 == 0)
                    {
                        matrix[j, i] = k++;
                    }
                    else
                    {
                        matrix[j, i] = k--;
                    }
                }
            }

            printMatrix(matrix);

        }

        static void printC()
        {
            Console.Write("Enter the size ot the matrix : ");
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int i = 1;
            matrix[matrix.GetLength(0) - 1, 0] = i;
            ++i;

            matrix[matrix.GetLength(0) - 2, 0] = i++;
            matrix[matrix.GetLength(0) - 1, 1] = i++;
            int temp = 3;

            while (temp < size)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (col == row - (size - temp))
                        {
                            matrix[row, col] = i;
                            ++i;
                        }
                    }
                }
                ++temp;
            }

            while (temp >= 3)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (row == col - (size - temp))
                        {
                            matrix[row, col] = i;
                            ++i;
                        }
                    }
                }
                --temp;

            }

            matrix[0, matrix.GetLength(1) - 2] = i++;
            matrix[1, matrix.GetLength(1) - 1] = i++;
            matrix[0, matrix.GetLength(1) - 1] = i++;

            printMatrix(matrix);
        }

        public static void printD()
        {
            Console.Write("Enter the size ot the matrix : ");
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int row = 0, col = 0;
            string direction = "down";

            for (int i = 1; i <= size * size; i++)
            {
                if (direction == "right" && (col > size - 1 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col--;
                    row--;
                }

                if (direction == "down" && (row > size - 1 || matrix[row, col] != 0))
                {
                    direction = "right";
                    row--;
                    col++;
                }
                
                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction = "down";
                    col++;
                    row++;
                }

                if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row++;
                    col--;
                }

                matrix[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
                }
            }

            printMatrix(matrix);
        }

        public static void printMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(" {0} ", matrix[row, col].ToString().PadLeft(2, ' '));
                }
                Console.WriteLine();
            }
        }
    }
}
