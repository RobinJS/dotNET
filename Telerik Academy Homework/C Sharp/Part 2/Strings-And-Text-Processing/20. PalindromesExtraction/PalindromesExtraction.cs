/* 20. Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
 */

using System;

namespace _20.PalindromesExtraction
{
    class PalindromesExtraction
    {
        static void Main()
        {
            Console.WriteLine("Enter some text to check for palkindromes:");
            //string text = Console.ReadLine();
            string text = "This is some text containing palindromes like ABBA, lamal, exe";

            string[] textSplitted = text.Split(' ', ',', '.', '!', '?', ':');

            foreach (string word in textSplitted)
            {
                if (word != "")
                {
                    bool isSymmetric = true;
                    for (int i = 0; i < word.Length / 2; i++)
                    {
                        if (word[i] != word[word.Length - i - 1])
                        {
                            isSymmetric = false;
                            break;
                        }
                    }

                    if (isSymmetric)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
}
