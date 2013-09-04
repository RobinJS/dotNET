// 1. Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

namespace _01.OddLinesPrinting
{
    class OddLinesPrinting
    {
        static void Main()
        {
            string filePath = @"../../odd-lines.txt";
            using (StreamReader reader = new StreamReader(filePath))
            {
                bool currentLineIsOdd = true;
                string currentLine = "";
                while (currentLine != null)
                {
                    currentLine = reader.ReadLine();
                    if (currentLineIsOdd)
                    {
                        Console.WriteLine(currentLine);
                        currentLineIsOdd = false;
                    }
                    else
                    {
                        currentLineIsOdd = true;
                    }
                }
            }
        }
    }
}
