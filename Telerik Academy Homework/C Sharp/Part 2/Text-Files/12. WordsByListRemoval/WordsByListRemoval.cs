// 12. Write a program that removes from a text file all words listed 
//  in given another text file. Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;

namespace _12.WordsByListRemoval
{
    class WordsByListRemoval
    {
        static void Main()
        {
            string textFilePath = @"../../text.txt";
            string wordsListPath = @"../../words-list.txt";

            try
            {
                string fileContent = ReadFileContent(textFilePath);
                List<string> wordsList = ReadWordsList(wordsListPath);
                string newContent = RemoveWords(fileContent, wordsList);
                SaveReplacement(newContent);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                Console.WriteLine(dnfe.Message);
            }
            catch (UnauthorizedAccessException uaae)
            {
                Console.WriteLine(uaae.Message);
            }
            catch (PathTooLongException ptle)
            {
                Console.WriteLine(ptle.Message);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }

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

        private static List<string> ReadWordsList(string textFilePath)
        {
            List<string> words = new List<string>();
            using (StreamReader reader = new StreamReader(textFilePath))
            {
                string currentLine = "";
                while (currentLine != null)
                {
                    currentLine = reader.ReadLine();
                    if (currentLine == null)
                    {
                        break;
                    }
                    words.Add(currentLine);
                }
            }
            return words;
        }

        private static string RemoveWords(string oldText, List<string> wordsList)
        {
            string newText = oldText;

            foreach (string word in wordsList)
            {
                newText = newText.Replace(word, "");
            }

            return newText;
        }

        private static void SaveReplacement(string replacedContent)
        {
            using (StreamWriter writer = new StreamWriter(@"../../newText.txt"))
            {
                writer.Write(replacedContent);
            }
        }
    }
}
