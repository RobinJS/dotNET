namespace MatrixWalk
{
    using System;

    public class Matrix
    {
        public static void Main()
        {
            // Console.WriteLine( "Enter a positive number " );
            // string input = Console.ReadLine(  );
            // int n = 0;
            // while ( !int.TryParse( input, out n ) || n < 0 || n > 100 )
            // {
            //     Console.WriteLine( "You haven't entered a correct positive number" );
            //     input = Console.ReadLine(  );
            // }
            int n = 5;
            int[,] matrix = new int[n, n];
            int numberToPrint = 1;
            int directionRow = 1;
            int directionCol = 1;
            int row = 0;
            int col = 0;

            while (true)
            {
                matrix[row, col] = numberToPrint;

                if (!IsNextCellFree(matrix, row, col))
                {
                    break;
                }

                if (row + directionRow >= n || row + directionRow < 0 || col + directionCol >= n || col + directionCol < 0 || matrix[row + directionRow, col + directionCol] != 0)
                {
                    while (row + directionRow >= n || row + directionRow < 0 || col + directionCol >= n || col + directionCol < 0 || matrix[row + directionRow, col + directionCol] != 0)
                    {
                        ChangeDirection(ref directionRow, ref directionCol);
                    }
                }

                row += directionRow;
                col += directionCol;
                numberToPrint++;
            }

            RestartTheWalk(matrix, out row, out col);

            if (row != 0 && col != 0)
            {
                directionRow = 1;
                directionCol = 1;

                while (true)
                {
                    matrix[row, col] = numberToPrint;
                    if (IsNextCellFree(matrix, row, col) == false)
                    {
                        break;
                    }

                    if (row + directionRow >= n || row + directionRow < 0 || col + directionCol >= n || col + directionCol < 0 || matrix[row + directionRow, col + directionCol] != 0)
                    {
                        while (row + directionRow >= n || row + directionRow < 0 || col + directionCol >= n || col + directionCol < 0 || matrix[row + directionRow, col + directionCol] != 0)
                        {
                            ChangeDirection(ref directionRow, ref directionCol);
                        }
                    }

                    row += directionRow;
                    col += directionCol;
                    numberToPrint++;
                }
            }

            PrintMatrix(matrix, n);
        }

        public static void ChangeDirection(ref int row, ref int col)
        {
            int[] directionRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionCol = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int currentDirection = 0;

            for (int index = 0; index < 8; index++)
            {
                if (directionRow[index] == row && directionCol[index] == col)
                {
                    currentDirection = index;
                    break;
                }
            }

            if (currentDirection == 7)
            {
                row = directionRow[0];
                col = directionCol[0];
                return;
            }

            row = directionRow[currentDirection + 1];
            col = directionCol[currentDirection + 1];
        }

        public static bool IsNextCellFree(int[,] matrix, int row, int col)
        {
            int[] directionRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionCol = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (row + directionRow[i] >= matrix.GetLength(0) || row + directionRow[i] < 0)
                {
                    directionRow[i] = 0;
                }

                if (col + directionCol[i] >= matrix.GetLength(0) || col + directionCol[i] < 0)
                {
                    directionCol[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (matrix[row + directionRow[i], col + directionCol[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static void RestartTheWalk(int[,] matrix, out int row, out int col)
        {
            row = 0;
            col = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        row = i;
                        col = j;
                        return;
                    }
                }
            }
        }

        public static void PrintMatrix(int[,] matrix, int n)
        {
            for (int matrixRow = 0; matrixRow < n; matrixRow++)
            {
                for (int matrixCol = 0; matrixCol < n; matrixCol++)
                {
                    Console.Write("{0,3}", matrix[matrixRow, matrixCol]);
                }

                Console.WriteLine();
            }
        }
    }
}
