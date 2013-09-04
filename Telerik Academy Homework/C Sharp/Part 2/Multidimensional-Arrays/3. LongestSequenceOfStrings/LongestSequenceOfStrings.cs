// We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LongestSequenceOfStrings
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
        //        matrix[row, col] = Console.ReadLine();
        //    }
        //}

        string[,] matrix = {
          { "ha", "fifi", "ho", "hi" },
          { "ha", "ha", "hi", "hi" },
          { "ha", "ho", "ho", "xx" },
          { "he", "hi", "ha", "xx" }
        };

        int longestSequence = int.MinValue;

        FindLongestSequence(matrix, longestSequence);
    }

    static void FindLongestSequence(string[,] matrix, int longestSequence)
    {
        int currentSum = 1;

        // Search horizontally
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currentSum += 1;
                    if (currentSum > longestSequence)
                    {
                        longestSequence = currentSum;
                    }
                }
                else
                {
                    currentSum = 1;
                }
            }
            currentSum = 1;
        }

        // Search vertically
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentSum += 1;
                    if (currentSum > longestSequence)
                    {
                        longestSequence = currentSum;
                    }
                }
                else
                {
                    currentSum = 1;
                }
            }
            currentSum = 1;
        }

        // Search diagonally left-to-right
        int startingPositionRow = 0;
        int startingPositionCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                startingPositionRow = row;
                startingPositionCol = col;
                while (row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1)
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        currentSum += 1;
                        if (currentSum > longestSequence)
                        {
                            longestSequence = currentSum;
                        }
                    }
                    else
                    {
                        currentSum = 1;
                        row = startingPositionRow;
                        col = startingPositionCol;
                        break;
                    }
                    row++;
                    col++;
                }
            }
            currentSum = 1;
        }

        // Search diagonally right-to-left
        startingPositionRow = 0;
        startingPositionCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = matrix.GetLength(1) - 1; col > 0; col--)
            {
                startingPositionRow = row;
                startingPositionCol = col;
                while (row < matrix.GetLength(0) - 1 && col > 0)
                {
                    if (matrix[row, col] == matrix[row + 1, col - 1])
                    {
                        currentSum += 1;
                        if (currentSum > longestSequence)
                        {
                            longestSequence = currentSum;
                        }
                    }
                    else
                    {
                        currentSum = 1;
                        row = startingPositionRow;
                        col = startingPositionCol;
                        break;
                    }
                    row++;
                    col--;
                }
            }
            currentSum = 1;
        }

        Console.WriteLine("The longest sequence of equal strings in the matrix is: {0}", longestSequence);
    }
}
