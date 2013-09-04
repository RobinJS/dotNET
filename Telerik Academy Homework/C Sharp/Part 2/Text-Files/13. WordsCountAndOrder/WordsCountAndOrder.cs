// 13. Write a program that reads a list of words from a file words.txt and finds how many times each of the words is
//  contained in another file test.txt. The result should be written in the file result.txt and the words should be
//  sorted by the number of their occurrences in descending order. Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _13.WordsCountAndOrder
{
    class WordsCountAndOrder
    {
        static void Main()
        {
            string textFilePath = @"../../text.txt";
            string wordsListPath = @"../../words.txt";

            try
            {
                string fileContent = ReadFileContent(textFilePath);
                List<string> wordsList = ReadWordsList(wordsListPath);
                Dictionary<string, int> wordsAppearances = CountWords(fileContent, wordsList);
                PrintResultInDescendingOrder(wordsAppearances);
                Console.WriteLine("Finished!");
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

        private static Dictionary<string, int> CountWords(string fileContent, List<string> wordsList)
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (string  word in  wordsList)
            {
                MatchCollection collection = Regex.Matches(fileContent, @"\b" + word + @"\w*\b", RegexOptions.IgnoreCase);
                int appearances = collection.Count;
                wordsCount.Add(word, appearances);
            }

            return wordsCount;
        }

        private static void PrintResultInDescendingOrder(Dictionary<string, int> wordsAppearances)
        {
            var newOrder = from pair in wordsAppearances
                        orderby pair.Value descending
                        select pair;

            using (StreamWriter writer = new StreamWriter(@"../../result.txt"))
            {
                foreach (var pair in newOrder)
                {
                    writer.WriteLine(pair.Key + " : " + pair.Value);
                }
            }
        }
    }
}
