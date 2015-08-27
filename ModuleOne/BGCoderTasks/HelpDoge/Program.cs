using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace HelpDoge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cords = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int rows = cords[0];
            int cols = cords[1];
            BigInteger[,] field = new BigInteger[rows, cols];

            int[] endCords = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int enemiesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < enemiesCount; i++)
            {
                int[] enemiesPositions = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

                field[enemiesPositions[0], enemiesPositions[1]] = -1;
            }
            //implement

            int tempRow = 0;

            for (int i = 1; i < cols; i++)
            {
                if (field[tempRow, i] != -1)
                {
                    field[tempRow, i] = 1;
                }
                else
                {
                    break;
                }
            }

            int tempCol = 0;

            for (int i = 1; i < rows; i++)
            {
                if (field[i, tempCol] != -1)
                {
                    field[i, tempCol] = 1;
                }
                else
                {
                    break;
                }
            }

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    if (field[i, j] != -1)
                    {
                        BigInteger sum = 0;
                        sum += (field[i - 1, j] == -1) ? 0 : field[i - 1, j];
                        sum += (field[i, j - 1] == -1) ? 0 : field[i, j - 1];

                        field[i, j] = sum;


                    }
                }
            }

            if (rows == 1 && cols == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine(field[endCords[0], endCords[1]]);
            }
        }

        private static void Print(int[,] matrix)
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
    }
}
