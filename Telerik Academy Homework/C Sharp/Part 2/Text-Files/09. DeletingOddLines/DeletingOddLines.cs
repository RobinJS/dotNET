// 9. Write a program that deletes from given text file all odd lines. 
//  The result should be in the same file.

using System;
using System.Collections.Generic;
using System.IO;

namespace _09.DeletingOddLines
{
    class DeletingOddLines
    {
        static void Main()
        {
            string filePath = @"../../text.txt";
            List<string> newLines = new List<string>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                bool currentLineIsOdd = true;
                string currentLine = "";
                while (currentLine != null)
                {
                    currentLine = reader.ReadLine();
                    if (currentLine == null)
                    {
                        break;
                    }

                    if (currentLineIsOdd)
                    {
                        newLines.Add("");
                        currentLineIsOdd = false;
                    }
                    else
                    {
                        newLines.Add(currentLine);
                        currentLineIsOdd = true;
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(filePath))
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
