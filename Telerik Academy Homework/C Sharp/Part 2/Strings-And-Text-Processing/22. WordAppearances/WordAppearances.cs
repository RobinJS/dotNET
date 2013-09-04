/*22. Write a program that reads a string from the console and lists all different words
 * in the string along with information how many times each word is found.
 */

using System;
using System.Collections.Generic;

namespace _22.WordAppearances
{
    class WordAppearances
    {
        static void Main()
        {
            Console.WriteLine("Enter some text to see how many times each word appears:");
            string text = Console.ReadLine();
            string[] textSplitted = text.Split(',', ' ');

            List<string> words = new List<string>();
            List<int> counter = new List<int>();

            for (int i = 0; i < textSplitted.Length; i++)
            {
                string currentWord = textSplitted[i];
                if (currentWord != "")
                {
                    if (words.IndexOf(currentWord) == -1)
                    {
                        words.Add(currentWord);
                        counter.Add(1);
                    }
                    else
                    {
                        int index = words.IndexOf(currentWord);
                        counter[index]++;
                    }
                }
            }

            Console.WriteLine("Letters : Appearances");
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine("{0} - {1}", words[i], counter[i]);
            }
        }
    }
}
