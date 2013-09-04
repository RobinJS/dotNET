// 4. Write a program that compares two text files line by line and prints
//  the number of lines that are the same and the number of lines that are different.
//  Assume the files have equal number of lines.

using System;
using System.Collections.Generic;
using System.IO;

namespace _04.LineByLineFileComparison
{
    class LineByLineFileComparison
    {
        static void Main()
        {
            string fileOnePath = @"../../file-to-compare-1.txt";
            string fileTwoPath = @"../../file-to-compare-2.txt";

            List<string> fileOneLines = ReadFileContent(fileOnePath);
            List<string> fileTwoLines = ReadFileContent(fileTwoPath);

            CompareTwoFiles(fileOneLines, fileTwoLines);
        }

        private static List<string> ReadFileContent(string filePath)
        {
            string currentLine = "";
            List<string> allLines = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (currentLine != null)
                {
                    currentLine = reader.ReadLine();
                    if (currentLine == null)
                    {
                        break;
                    }

                    allLines.Add(currentLine);
                }
            }

            return allLines;
        }

        private static void CompareTwoFiles(List<string> fileOneLines, List<string> fileTwoLines)
        {
            int sameLines = 0;
            int differentLines = 0;

            for (int i = 0; i < fileOneLines.Count; i++)
            {
                if (fileOneLines[i] == fileTwoLines[i])
                {
                    sameLines++;
                }
                else
                {
                    differentLines++;
                }
            }

            Console.WriteLine("Same lines: {0}\nDifferent lines: {1}", sameLines, differentLines);
        }
    }
}
