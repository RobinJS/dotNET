/* 13. Write a program that reverses the words in given sentence.
 *  Example: "C# is not C++, not PHP and not Delphi!"
 *  Result: "Delphi not and PHP, not C++ not is C#!".
 */

using System;
using System.Linq;
using System.Text;

namespace _13.ReversingWords
{
    class ReversingWords
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();
            //string sentence = "C# is not C++, not PHP and not Delphi!";
            char[] marks = { ' ', '.', '?', '!' };
            string[] words = sentence.Split(marks);

            StringBuilder newSentence = new StringBuilder();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (words[i] != "")
                {
                    newSentence.Append(words[i] + " ");
                }
            }

            if (marks.Contains(sentence[sentence.Length - 1]))
            {
                newSentence.Append("\b" + sentence[sentence.Length - 1]);
            }

            Console.WriteLine(newSentence);
        }
    }
}
