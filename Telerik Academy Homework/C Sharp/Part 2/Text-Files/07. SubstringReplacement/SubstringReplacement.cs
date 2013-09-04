// 7. Write a program that replaces all occurrences of the substring "start" 
//  with the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

namespace _07.SubstringReplacement
{
    class SubstringReplacement
    {
        static void Main()
        {
            string filePath = @"../../text.txt";
            string fileContent = ReadFileContent(filePath);
            string replacedContent = ReplaceContent(fileContent);
            SaveReplacement(replacedContent);
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
            string replaced = fileContent.Replace("start", "finish");
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
