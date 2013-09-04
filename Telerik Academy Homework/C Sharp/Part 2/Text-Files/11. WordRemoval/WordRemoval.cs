// 11. Write a program that deletes from a text file all words that start
//  with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _11.WordRemoval
{
    class WordRemoval
    {
        static void Main()
        {
            string filePath = @"../../text.txt";
            string fileContent = ReadFileContent(filePath);
            string newContent = ReplaceContent(fileContent);
            SaveReplacement(newContent);
            Console.WriteLine("Finished!");
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

        private static string ReplaceContent(string fileContent)
        {
            string replaced = Regex.Replace(fileContent, @"\btest\w*\b", "");
            return replaced;
        }

        private static void SaveReplacement(string replacedContent)
        {
            using (StreamWriter writer = new StreamWriter(@"../../text.txt"))
            {
                writer.Write(replacedContent);
            }
        }
    }
}
