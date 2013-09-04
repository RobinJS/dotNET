using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Matrix
{
    static void Main()
    {
        Console.WriteLine("Enter size for matrix:");
        int matrixSize = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter matrix type (a, b, c or d):");
        string matrixType = Console.ReadLine();
        Console.WriteLine();

        int[,] matrix = new int[matrixSize, matrixSize];

        if (matrixType == "a")
        {
            matrix = createMatrixTypeA(matrixSize, matrix);
        }
        else if (matrixType == "b")
        {
            matrix = createMatrixTypeB(matrixSize, matrix);
        }
        else if (matrixType == "c")
        {
            matrix = createMatrixTypeC(matrixSize, matrix);
        }
        else if (matrixType == "d")
        {
            matrix = createMatrixTypeD(matrixSize, matrix);
        }
        else
        {
            Console.WriteLine("Invalid matrix type!");
        }


        PrintingMatrix(matrixSize, matrix);
    }

    // Creating Matrix Type "a"
    static int[,] createMatrixTypeA(int matrixSize, int[,] matrix)
    {
        int index = 1;

        for (int cols = 0; cols < matrixSize; cols++)
        {
            for (int rows = 0; rows < matrixSize; rows++)
            {
                matrix[rows, cols] = index++;
            }
        }

        return matrix;
    }

    // Creating Matrix Type "b"
    static int[,] createMatrixTypeB(int matrixSize, int[,] matrix)
    {
        int index = 1;
        int rows = 0;
        int cols = 0;

        while (rows < matrixSize)
        {
            matrix[rows, cols] = index++;
            rows++;
        }
        rows--;
        cols++;
        while (rows >= 0)
        {
            matrix[rows, cols] = index++;
            rows--;
        }
        rows++;
        cols++;
        while (rows < matrixSize)
        {
            matrix[rows, cols] = index++;
            rows++;
        }
        rows--;
        cols++;
        while (rows >= 0)
        {
            matrix[rows, cols] = index++;
            rows--;
        }

        return matrix;
    }

    // Creating Matrix Type "c"
    static int[,] createMatrixTypeC(int matrixSize, int[,] matrix)
    {
        int index = 1;
        int columnBeginning = 0;        // first available column
        int rowEnd = matrixSize - 1;    // last available row
        int row = matrixSize - 1;       // setting starting row for the first iteration
        int col = 0;                    // setting starting column for the first iteration
        matrix[row, col] = index;       // initializing the first cell of the sequence

        while (index < matrixSize * matrixSize) // loop until the last cell is filled
        {
            if (row == rowEnd)      // if this is the last row
            {
                if (col == matrixSize - 1)  // if this is the last column, change where to start and where to stop next initializing
                {
                    columnBeginning++;
                    rowEnd--;
                }
                col = columnBeginning;
                row--;

                if (matrix[row, col] > 0)       // if the cell is not empty
                {
                    while (matrix[row, col] > 1)    // find next available row
                    {
                        row--;
                    }
                }
            }
            else
            {
                col++;
                row++;
            }

            index++;
            matrix[row, col] = index;
        }

        return matrix;
    }

    // Creating Matrix Type "d"
    static int[,] createMatrixTypeD(int matrixSize, int[,] matrix)
    {
        int index = 1;
        int row = 0;
        int col = 0;
        int maxNumber = matrixSize * matrixSize;

        while (index <= maxNumber)
        {
            // moving down
            for (int i = row; i < matrixSize; i++)
            {
                if (matrix[row, col] != 0)
                {
                    break;
                }

                matrix[row, col] = index++;
                row++;
            }

            row--;
            col++;

            // moving right
            for (int i = col; i < matrixSize; i++)
            {
                if (matrix[row, col] != 0)
                {
                    break;
                }

                matrix[row, col] = index++;
                col++;
            }

            col--;
            row--;

            // moving up
            for (int i = row; i >= 0; i--)
            {
                if (matrix[row, col] != 0)
                {
                    break;
                }

                matrix[row, col] = index++;
                row--;
            }

            row++;
            col--;

            // moving left
            for (int i = col; i >= 0; i--)
            {
                if (matrix[row, col] != 0)
                {
                    break;
                }

                matrix[row, col] = index++;
                col--;
            }

            col++;
            row++;
        }

        return matrix;
    }

    // Printing the Matrix
    static void PrintingMatrix(int matrixSize, int[,] matrix)
    {

        for (int rows = 0; rows < matrixSize; rows++)
        {
            for (int cols = 0; cols < matrixSize; cols++)
            {
                Console.Write("{0, -3}", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
    }
}
