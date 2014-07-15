using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._08_2._10_Matrix
{
    class Matrix<T> where T : struct, IComparable
    {
        private T[,] _Matrix;

        public Matrix(int width, int height)
        {
            _Matrix = new T[width, height];
            this.Width = width;
            this.Height = height;
        }

        public int Width { private set; get; }
        public int Height { private set; get; }

        public T this[int width, int height]
        {
            get { return this._Matrix[width, height]; }
            set { this._Matrix[width, height] = value; }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.Width, firstMatrix.Height);
            try
            {
                for (int i = 0; i < firstMatrix.Width; i++)
                {
                    for (int j = 0; j < firstMatrix.Height; j++)
                    {
                        newMatrix[i, j] = (dynamic)firstMatrix[i, j] + secondMatrix[i, j];
                    }
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                throw ae;
            }
            return newMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> fistMatrix, Matrix<T> secondMatrix)
        {
            Matrix<T> newMatrix = new Matrix<T>(fistMatrix.Width, fistMatrix.Height);
            try
            {
                for (int i = 0; i < fistMatrix.Width; i++)
                {
                    for (int j = 0; j < fistMatrix.Height; j++)
                    {
                        newMatrix[i, j] = (dynamic)fistMatrix[i, j] - secondMatrix[i, j];
                    }
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                throw ae;
            }
            return newMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> fistMatrix, Matrix<T> secondMatrix)
        {
            Matrix<T> newMatrix = new Matrix<T>(fistMatrix.Width, fistMatrix.Height);
            try
            {
                for (int i = 0; i < fistMatrix.Width; i++)
                {
                    for (int j = 0; j < fistMatrix.Height; j++)
                    {
                        newMatrix[i, j] = (dynamic)fistMatrix[i, j] * secondMatrix[i, j];
                    }
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                throw ae;
            }
            return newMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Width; i++)
            {
                for (int j = 0; j < matrix.Height; j++)
                {
                    if ((dynamic)matrix[i, j] != default(T))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Width; i++)
            {
                for (int j = 0; j < matrix.Height; j++)
                {
                    if ((dynamic)matrix[i, j] != default(T))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
