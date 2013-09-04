/*23. Write a program that reads a string from the console and replaces all series
 * of consecutive identical letters with a single one.
 * Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".
 */

using System;
using System.Text;

namespace _23.IdenticalLettersToSingle
{
    class IdenticalLettersToSingle
    {
        static void Main()
        {
            Console.WriteLine("Enter some text containing consecutive identical letters:");
            string text = Console.ReadLine();

            StringBuilder newText = new StringBuilder();

            for (int i = 0; i < text.Length - 1; i++)
            {
                char currentChar = text[i];
                char nextChar = text[i + 1];

                if (nextChar != currentChar || i == text.Length)
                {
                    newText.Append(currentChar);
                }
            }

            newText.Append(text[text.Length - 1]);  // after all we need to add the last letter

            Console.WriteLine("New text:");
            Console.WriteLine(newText);
        }
    }
}
