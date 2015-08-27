using System;
using System.Linq;

namespace DodgeCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cords = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int rows = cords[0];
            int cols = cords[1];
            int [,] field = new int[rows, cols];

            int total = int.Parse(Console.ReadLine());

            for (int i = 0; i < total; i++)
            {
                int[] curr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

                field[curr[0], curr[1]]++;
            }

            int currentcell = 0;

            int row = 0;

            for (int col = 1; col < cols; col++)
            {

                field[row, col] += field[row, col - 1];
            }

            int currcol = 0;

            for (int i = 1; i < rows; i++)
            {
                field[i, currcol] += field[i - 1, currcol];
            }

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    field[i, j] += Math.Max(field[i - 1, j], field[i, j - 1]);
                }
            }

            Console.WriteLine(field[rows - 1, cols - 1]);     
        }
    }
}
