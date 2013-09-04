// 5. Write a program that reads a text file containing a square matrix of numbers
//  and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
//  The first line in the input file contains the size of matrix N. Each of the next N lines
//  contain N numbers separated by space. The output should be a single number in a separate
//  text file. Example:
//  4
//  2 3 3 4
//  0 2 3 4
//  3 7 1 2
//  4 3 3 2
//
//  Area with maximal sum: 3 7, 4 3
//  Output: 17

using System;
using System.IO;

namespace _05.Matrix
{
    class Matrix
    {
        static void Main()
        {
            string filePath = @"../../matrix.txt";

            int[,] matrix = ReadMatrix(filePath);

            int maximalSum = FindMaximalSumArea(matrix);

            PrintSumIntoFile(maximalSum);

        }

        private static int[,] ReadMatrix(string filePath)
        {
            var matrixSize = 0;
            int[,] matrix = new int[matrixSize, matrixSize];

            using (StreamReader reader = new StreamReader(filePath))
            {
                string currentLine = "";
                int lineIndex = 1;
                int matrixRow = 0;
                string[] currentRow;

                while (currentLine != null)
                {
                    currentLine = reader.ReadLine();
                    if (currentLine == null)
                    {
                        break;
                    }

                    if (lineIndex > 1)
                    {
                        currentRow = currentLine.Split(' ');

                        // initializing each matrix row
                        for (int col = 0; col < currentRow.Length; col++)
                        {
                            matrix[matrixRow, col] = int.Parse(currentRow[col]);
                        }

                        matrixRow++;
                    }
                    else
                    {
                        matrixSize = int.Parse(currentLine);
                        matrix = new int[matrixSize, matrixSize];
                    }

                    lineIndex++;
                }
            }

            return matrix;
        }

        private static int FindMaximalSumArea(int[,] matrix)
        {
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum < currentSum)
                    {
                        sum = currentSum;
                    }
                }
            }

            return sum;
        }

        private static void PrintSumIntoFile(int maximalSum)
        {
            string outputPath = @"../../output.txt";
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                writer.WriteLine(maximalSum);
            }

            Console.WriteLine("Finished!");
        }
    }
}
