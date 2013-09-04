//3. Write a program that counts how many times each word from given text file "words.txt"
//appears in it. The character casing differences should be ignored.
//The result words should be ordered by their number of occurrences in the text.
//    Example: "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?"
//      is -> 2
//      the -> 2
//      this -> 3
//      text -> 6

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3.WordsAppearancesCount
{
    class WordsAppearancesCount
    {
        static void Main()
        {
            string filePath = @"../../text.txt";

            StreamReader reader = new StreamReader(filePath);
            string text;
            using (reader)
            {
                text = reader.ReadToEnd();
            }

            Console.WriteLine("Text: {0}", text);
            text = text.ToLower();
            char[] separators = { ' ', '.', ',', '-', '!', '?' };

            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordOccurances = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!wordOccurances.ContainsKey(word))
                {
                    wordOccurances.Add(word.Trim(), 0);
                }
                wordOccurances[word]++;
            }

            foreach (KeyValuePair<string, int> pair in wordOccurances.OrderBy(x => x.Value))
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
