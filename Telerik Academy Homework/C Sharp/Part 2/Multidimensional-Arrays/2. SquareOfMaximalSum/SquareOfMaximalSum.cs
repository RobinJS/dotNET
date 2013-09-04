//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SquareOfMaximalSum
{
    static void Main()
    {
        //Console.WriteLine("Enter size (N x M) for the matrix.");
        //Console.WriteLine("Enter a positive integer for N (rows):");
        //int N = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter a positive integer for M (columns):");
        //int M = int.Parse(Console.ReadLine());

        //int[,] matrix = new int[N,M];

        //for (int row = 0; row < N; row++)
        //{
        //    for (int col = 0; col < M; col++)
        //    {
        //        Console.WriteLine("Cell [{0}, {1}]:", row, col);
        //        matrix[row, col] = int.Parse(Console.ReadLine());
        //    }
        //}

        int[,] matrix = {
          {7, 1, 3, 3, 2, 1},
          {1, 3, 9, 8, 5, 6},
          {4, 6, 7, 9, 1, 0}
        };

        int maxSum = int.MinValue;

        FindMaxSum(matrix, maxSum);
    }

    static void FindMaxSum(int[,] matrix, int maxSum)
    {
        int startingRow = 0;
        int startingCol = 0;
        int endingRow = 0;
        int endingCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > maxSum)
                {
                    maxSum = sum;

                    startingRow = row;
                    startingCol = col;
                    endingRow = row + 2;
                    endingCol = col + 2;
                }
            }
        }

        PrintResult(maxSum, startingRow, startingCol, endingRow, endingCol);
    }

    static void PrintResult(int maxSum, int startingRow, int startingCol, int endingRow, int endingCol)
    {
        Console.WriteLine("The maximal sum is: {0}", maxSum);
        Console.WriteLine("The square starts from element [{0},{1}] (top left corner of the square) to element [{2},{3}] (bottom right corner of the square)", startingRow, startingCol, endingRow, endingCol);
    }
}
