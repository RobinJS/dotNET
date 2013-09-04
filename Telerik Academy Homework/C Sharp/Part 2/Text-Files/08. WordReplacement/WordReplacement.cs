// 8. Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _08.WordReplacement
{
    class WordReplacement
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
            string replaced = Regex.Replace(fileContent, @"\bstart\b", "finish");
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
