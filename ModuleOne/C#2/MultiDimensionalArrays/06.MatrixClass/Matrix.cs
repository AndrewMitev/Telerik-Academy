using System;
using System.Collections.Generic;
using System.Linq;


namespace _06.MatrixClass
{
    class Matrix
    {
        public int[,] matrix;
        public const string message = "you cannot do that";

        public Matrix(int[,] c1)
        {
            this.matrix = c1;
        }

        public static Matrix operator +(Matrix c1, Matrix c2)
        {
            int[,] matrix = new int[c1.matrix.GetLength(0), c1.matrix.GetLength(1)];
            matrix[0, 0] = c1.matrix[0, 0] + c2.matrix[0, 0];

            return new Matrix(matrix);
        }

        public static Matrix operator -(Matrix c1, Matrix c2)
        {

            int[,] matrix = new int[c1.matrix.GetLength(0), c1.matrix.GetLength(1)];
            matrix[0, 0] = c1.matrix[0, 0] - c2.matrix[0, 0];

            return new Matrix(matrix);
        }

        public static Matrix operator *(Matrix c1, Matrix c2)
        {

            int[,] matrix = new int[c1.matrix.GetLength(0), c1.matrix.GetLength(1)];
            matrix[0, 0] = c1.matrix[0, 0] * c2.matrix[0, 0];

            return new Matrix(matrix);
        }

        public override string ToString()
        {
            string str = null;

            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    str += this.matrix[i, j] + " ";
                }
            }
            return str;
        }
    }
}
