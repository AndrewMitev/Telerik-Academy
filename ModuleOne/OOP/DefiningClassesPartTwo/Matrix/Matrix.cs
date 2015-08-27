using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class CustomMatrix<T> where T : struct
    {
        private T[,] array;

        public T[,] Array { get; set; }

        public CustomMatrix(T[,] arr)
        {
            this.Array = arr;
        }

        public T this[int row, int col]
        {
            get
            {
                if ( row >= 0 || row < this.array.GetLength(0) || col >= 0 || col < this.array.GetLength(1))
                {
                    return this.array[row, col];
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
            }
            set
            {
                if (row >= 0 || row < this.array.GetLength(0) || col >= 0 || col < this.array.GetLength(1))
                {
                    this.array[row, col] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
            }
        }

        public static CustomMatrix<T> operator +(CustomMatrix<T> firstMatrix, CustomMatrix<T> secondMatrix)
        {
            if (firstMatrix.Array.GetLength(0) != secondMatrix.Array.GetLength(0) || firstMatrix.Array.GetLength(1) != secondMatrix.Array.GetLength(1))
            {
                throw new Exception("Invalid operation!");
            }

            int rows = firstMatrix.Array.GetLength(0);
            int cols = secondMatrix.Array.GetLength(1);

            T[,] newArray = new T[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    newArray[i, j] = (dynamic)firstMatrix.Array[i, j] + secondMatrix.Array[i, j];
                }
            }

            var newMatrix = new CustomMatrix<T>(newArray);
            return newMatrix;
        }

        public static CustomMatrix<T> operator -(CustomMatrix<T> firstMatrix, CustomMatrix<T> secondMatrix)
        {
            if (firstMatrix.Array.GetLength(0) != secondMatrix.Array.GetLength(0) || firstMatrix.Array.GetLength(1) != secondMatrix.Array.GetLength(1))
            {
                throw new Exception("Invalid operation!");
            }

            int rows = firstMatrix.Array.GetLength(0);
            int cols = secondMatrix.Array.GetLength(1);

            T[,] newArray = new T[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    newArray[i, j] = (dynamic)firstMatrix.Array[i, j] - secondMatrix.Array[i, j];
                }
            }

            var newMatrix = new CustomMatrix<T>(newArray);
            return newMatrix;
        }

        public static CustomMatrix<T> operator *(CustomMatrix<T> firstMatrix, CustomMatrix<T> secondMatrix)
        {
            if (firstMatrix.Array.GetLength(0) != secondMatrix.Array.GetLength(0) || firstMatrix.Array.GetLength(1) != secondMatrix.Array.GetLength(1))
            {
                throw new Exception("Invalid operation!");
            }

            int rows = firstMatrix.Array.GetLength(0);
            int cols = secondMatrix.Array.GetLength(1);

            T[,] newArray = new T[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    newArray[i, j] = (dynamic)firstMatrix.Array[i, j] * secondMatrix.Array[i, j];
                }
            }

            var newMatrix = new CustomMatrix<T>(newArray);
            return newMatrix;
        }

        public static bool operator true(CustomMatrix<T> matrix)
        {
            for (int i = 0; i < matrix.array.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.array.GetLength(1); j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(CustomMatrix<T> matrix)
        {
            for (int i = 0; i < matrix.array.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.array.GetLength(1); j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }


    }
}
