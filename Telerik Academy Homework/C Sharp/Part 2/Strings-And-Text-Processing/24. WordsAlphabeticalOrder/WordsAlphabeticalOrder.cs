/*24. Write a program that reads a list of words, separated by spaces 
 * and prints the list in an alphabetical order.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _24.WordsAlphabeticalOrder
{
    class WordsAlphabeticalOrder
    {
        static void Main()
        {
            Console.WriteLine("Enter a list of words, separated by spaces:");
            string input = Console.ReadLine();

            List<string> words = new List<string>(input.Split(' '));

            List<string> sortedWords = words.OrderBy(x => x).ToList();

            foreach (string word in sortedWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
