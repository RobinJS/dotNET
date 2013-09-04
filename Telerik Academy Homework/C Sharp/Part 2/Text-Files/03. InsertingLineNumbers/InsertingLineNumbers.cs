// 3. Write a program that reads a text file and inserts line numbers in front of
//  each of its lines. The result should be written to another text file.

using System;
using System.Collections.Generic;
using System.IO;

namespace _03.InsertingLineNumbers
{
    class InsertingLineNumbers
    {
        static void Main()
        {
            string filePath = @"../../file-to-read.txt";
            List<string> newLines = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string currentLine = "";
                int lineIndex = 1;

                while (currentLine != null)
                {
                    currentLine = reader.ReadLine();
                    if (currentLine == null)
                    {
                        break;
                    }

                    newLines.Add(lineIndex + " " + currentLine);
                    lineIndex++;
                }
            }

            using (StreamWriter writer = new StreamWriter(@"../../result-file.txt"))
            {
                foreach (string line in newLines)
                {
                    writer.WriteLine(line);
                }
            }

            Console.WriteLine("Finished!");
        }
    }
}
