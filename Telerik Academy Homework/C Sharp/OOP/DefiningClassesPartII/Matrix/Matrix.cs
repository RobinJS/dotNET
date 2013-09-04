using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix
{
    class Matrix<T>
    {
        private int rows;
        private int cols;
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
        }

        public int Rows
        {
            get { return this.rows; }
            set { this.rows = value; }
        }

        public int Cols
        {
            get { return this.cols; }
            set { this.cols = value; }
        }

        public T this[int row, int col]
        {
            get
            {
                return matrix[row, col];
            }
            set
            {
                matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            try
            {
                return new Matrix<T>(m1.rows + m2.rows, m1.cols + m2.cols);
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("This operation cannot be performed. Both matrices must be the same size.");
            }
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            try
            {
                return new Matrix<T>(m1.rows - m2.rows, m1.cols - m2.cols);
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("This operation cannot be performed. Both matrices must be the same size.");
            }
        }

        public static Matrix<T> operator *(Matrix<T> m1, int coef)
        {
            try
            {
                return new Matrix<T>(m1.rows * coef, m1.cols * coef);
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("This operation cannot be performed.");
            }
        }

        public static bool operator true(Matrix<T> m)
        {
            for (int row = 0; row < m.rows; row++)
            {
                for (int col = 0; col < m.cols; col++)
                {
                    if (m[row, col].Equals(0))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> m)
        {
            for (int row = 0; row < m.rows; row++)
            {
                for (int col = 0; col < m.cols; col++)
                {
                    if (m[row, col].Equals(0))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}