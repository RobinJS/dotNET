/* 21. Write a program that reads a string from the console and prints 
 * all different letters in the string along with information how many times 
 * each letter is found.
 */

using System;
using System.Collections.Generic;

namespace _21.LettersAppearances
{
    class LettersAppearances
    {
        static void Main()
        {
            Console.WriteLine("Enter some text to see how many times each letter appears:");
            string text = Console.ReadLine();

            List<char> letters = new List<char>();
            List<int> counter = new List<int>();

            for (int i = 0; i < text.Length; i++)
            {
                char currentLetter = text[i];
                if (currentLetter != ' ')
                {
                    if (letters.IndexOf(currentLetter) == -1)
                    {
                        letters.Add(currentLetter);
                        counter.Add(1);
                    }
                    else
                    {
                        int index = letters.IndexOf(currentLetter);
                        counter[index]++;
                    }
                }
            }

            Console.WriteLine("Letters : Appearances");
            for (int i = 0; i < letters.Count; i++)
            {
                Console.WriteLine("{0} - {1}", letters[i], counter[i]);
            }
        }
    }
}
