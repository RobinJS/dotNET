// 6. Write a program that reads a text file containing a list of strings, 
//  sorts them and saves them to another text file. Example:
//  Ivan            George
//  Peter   --->    Ivan
//  Maria           Maria
//  George          Peter

using System;
using System.Collections.Generic;
using System.IO;

namespace _06.StringSort
{
    class StringsSort
    {
        static void Main()
        {
            string filePath = @"../../input.txt";
            List<string> strings = ReadStrings(filePath);

            strings.Sort();
            SaveToFile(strings);
            Console.WriteLine("Finished!");
        }

        private static List<string> ReadStrings(string filePath)
        {
            List<string> list = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string currentString = "";

                while (currentString != null)
                {
                    currentString = reader.ReadLine();
                    if (currentString == null)
                    {
                        break;
                    }

                    list.Add(currentString);
                }
            }

            return list;
        }

        private static void SaveToFile(List<string> strings)
        {
            using (StreamWriter writer = new StreamWriter(@"../../sorted.txt"))
            {
                foreach (string str in strings)
                {
                    writer.WriteLine(str);
                }
            }
        }
    }
}
