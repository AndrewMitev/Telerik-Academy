namespace LoverOfTwo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    internal class Program
    {
        public static void Main(string[] args)
        {
            long rows = long.Parse(Console.ReadLine());
            long cols = long.Parse(Console.ReadLine());

            long numberN = long.Parse(Console.ReadLine());

            BigInteger[,] field = LoadField(rows, cols);

            BigInteger[] codes = Console.ReadLine()
                .Split(' ')
                .Select(x => BigInteger.Parse(x))
                .ToArray();

            long coeficient = Math.Max(rows, cols);

            BigInteger sum = 0;

            List<decimal> targetRows = new List<decimal>();
            List<decimal> targetCols = new List<decimal>();

            foreach (long code in codes)
            {
                long row = code / coeficient;
                long col = code % coeficient;

                targetRows.Add(row);
                targetCols.Add(col);
            }

            long currentPositionRow;
            long currentPositionCol;

            if (rows == 1 && cols == 1)
            {
                currentPositionRow = 0;
                currentPositionCol = 0;
            }
            else
            {
                currentPositionRow = rows - 1;
                currentPositionCol = 0;
            }

            for (int i = 0; i < targetRows.Count; i++)
            {
                decimal steps = Math.Abs(currentPositionRow) - Math.Abs(targetRows[i]);

                if (steps < 0)
                {
                    steps *= -1;
                }

                while (steps != 0)
                {
                    if (currentPositionRow > targetRows[i])
                    {
                        currentPositionRow--;
                    }
                    else if (currentPositionRow < targetRows[i])
                    {
                        currentPositionRow++;
                    }

                    sum += field[currentPositionRow, currentPositionCol];
                    field[currentPositionRow, currentPositionCol] = 0;

                    steps--;
                }

                decimal secondSteps = Math.Abs(currentPositionCol) - Math.Abs(targetCols[i]);

                if (secondSteps < 0)
                {
                    secondSteps *= -1;
                }

                while (secondSteps != 0)
                {
                    if (currentPositionCol > targetCols[i])
                    {
                        currentPositionCol--;
                    }
                    else if (currentPositionCol < targetCols[i])
                    {
                        currentPositionCol++;
                    }

                    sum += field[currentPositionRow, currentPositionCol];
                    field[currentPositionRow, currentPositionCol] = 0;

                    secondSteps--;
                }
            }

            Console.WriteLine(sum + 1);
        }

        private static BigInteger[,] LoadField(long rows, long cols)
        {
            if (rows < 0 || cols < 0)
            {
                throw new ArgumentException("LoadField(): pass non-negative parameters.");    
            }

            BigInteger[,] matrix = new BigInteger[rows, cols];

            matrix[rows - 1, 0] = 0;

            for (long i = rows - 2, j = 1; i >= 0; i--, j++)
            {
                matrix[i, 0] = PowNumberTwo(j);
            }

            for (int i = 1, j = 1; i < cols; i++, j++)
            {
                matrix[rows - 1, i] = PowNumberTwo(j);
            }

            for (long i = rows - 2; i >= 0; i--)
            {
                for (int j = 1; j < cols; j++)
                {
                    matrix[i, j] = matrix[i, j - 1] + matrix[i + 1, j];
                }
            }

            return matrix;
        }

        private static void PrintField(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("PrintField(): must pass parameter!");
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        private static BigInteger PowNumberTwo(long j)
        {
            BigInteger pow = 1;

            for (int i = 1; i <= j; i++)
            {
                pow *= 2;
            }

            return pow;
        }
    }
}
