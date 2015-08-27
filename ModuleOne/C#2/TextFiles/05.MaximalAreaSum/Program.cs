using System;
using System.IO;

/*
 * @ Task
 * Write a program that reads a text file containing a square matrix of numbers.
 */
namespace _05.MaximalAreaSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = LoadMatrix();

            try
            {
                StreamWriter writer = new StreamWriter("../../MaxSum.txt");

                using (writer)
                {
                    writer.WriteLine(FindMaxSumInArea(matrix));
                    Console.WriteLine("Data was written to file.\nCheck it's content please if you want to do your job properly!");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File is non - existent in the selected directory!");
            }
            catch (FileLoadException)
            {
                Console.WriteLine("File couldn't be loaded!");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null Reference Exception");
            }
        }

        private static int[,] LoadMatrix()
        {
            int[,] matrix = null;
            int N;

            try
            {
                StreamReader reader = new StreamReader("../../MatrixData.txt");

                using (reader)
                {
                    N = int.Parse(reader.ReadLine());
                    matrix = new int[N, N];

                    for (int i = 0; i < N; i++)
                    {
                        string[] nums = reader.ReadLine().Split(' ');

                        for (int j = 0; j < N; j++)
                        {
                            matrix[i, j] = int.Parse(nums[j]);
                        }
                    }

                }

                return matrix;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("FileNotFound");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException");
            }
            catch (FormatException)
            {
                Console.WriteLine("Read data is invalid!");
            }

            return matrix;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int FindMaxSumInArea(int[,] matrix)
        {
            int max = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int curr = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (curr > max)
                    {
                        max = curr;
                    }
                }
            }

            return max;
        }
    }
}
