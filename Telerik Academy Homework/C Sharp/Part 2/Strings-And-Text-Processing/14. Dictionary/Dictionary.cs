/* 14. A dictionary is stored as a sequence of text lines containing words and their explanations.
 * Write a program that enters a word and translates it by using the dictionary.
 * Sample dictionary:
 *      .NET – platform for applications from Microsoft
 *      CLR – managed execution environment for .NET
 *      namespace – hierarchical organization of classes
 */

using System;
using System.Collections.Generic;

namespace _14.Dictionary
{
    class Dictionary
    {
        static void Main()
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();

            List<string> words = new List<string> {
                             ".NET",
                             "CLR",
                             "namespace"
                             };

            List<string> explanations = new List<string> {
                                    "platform for applications from Microsoft",
                                    "managed execution environment for .NET",
                                    "hierarchical organization of classes"
                                    };

            if (words.IndexOf(word) != -1)
            {
                Console.WriteLine("{0} - {1}", word, explanations[words.IndexOf(word)]);
            }
            else
            {
                Console.WriteLine("Sorry, but there is no description of this word!");
            }
        }
    }
}
