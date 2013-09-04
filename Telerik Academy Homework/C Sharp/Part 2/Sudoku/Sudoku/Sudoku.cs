using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    class Sudoku
    {
        static void Main()
        {
            //char[,] unsolved = new char[9,9];

            //for (int i = 0; i < 9; i++)
            //{
            //    string input = Console.ReadLine();
            //    for (int j = 0; j < 9; j++)
            //    {
            //        unsolved[i, j] = input[j];
            //    }
            //}

            char[,] unsolved = 
            {
                {'5', '3', '-', '-', '7', '-', '-', '-', '-'},
                {'6', '-', '-', '1', '9', '5', '-', '-', '-'},
                {'-', '9', '8', '-', '-', '-', '-', '6', '-'},
                {'8', '-', '-', '-', '6', '-', '-', '-', '3'},
                {'4', '-', '-', '8', '-', '3', '-', '-', '1'},
                {'7', '-', '-', '-', '2', '-', '-', '-', '6'},
                {'-', '6', '-', '-', '-', '-', '2', '8', '-'},
                {'-', '-', '-', '4', '1', '9', '-', '-', '5'},
                {'-', '-', '-', '-', '8', '-', '-', '7', '9'}
            };

            SolveSquare1(unsolved);

        }

        private static void SolveSquare1(char[,] unsolved)
        {
            byte startRow = 0;
            byte startCol = 0;

            string allNumbers = "123456789";

            List<char> usedNumbers = new List<char>();

            List<char> possibleNumbers = new List<char>();

            for (int row = startRow; row <= 2; row++)
            {
                for (int col = startCol; col <= 2; col++)
                {
                    if (unsolved[row, col] != '-')
                    {
                        usedNumbers.Add(unsolved[row, col]);
                    }
                }
            }

            //// find possible numbes
            //foreach (char num in allNumbers)
            //{
            //    if (usedNumbers.IndexOf(num) < 0)
            //    {
            //        possibleNumbers.Add(num);
            //    }
            //}

            
        }
    }
}
