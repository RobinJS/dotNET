// 2. Write a program that concatenates two text files into another text file.

using System;
using System.IO;
using System.Text;

namespace _02.TextFilesConcatenation
{
    class TextFilesConcatenation
    {
        static void Main()
        {
            string fileOnePath = @"../../file1.txt";
            string fileTwoPath = @"../../file2.txt";

            string fileOneContent = ReadFileContent(fileOnePath);
            string fileTwoContent = ReadFileContent(fileTwoPath);

            StringBuilder bothFilesContent = new StringBuilder();
            bothFilesContent.Append(fileOneContent).Append("\n").Append(fileTwoContent);

            Console.WriteLine(bothFilesContent);
        }

        private static string ReadFileContent(string filePath)
        {
            string content = "";
            using (StreamReader reader = new StreamReader(filePath))
            {
                content = reader.ReadToEnd();
            }

            return content;
        }
    }
}
