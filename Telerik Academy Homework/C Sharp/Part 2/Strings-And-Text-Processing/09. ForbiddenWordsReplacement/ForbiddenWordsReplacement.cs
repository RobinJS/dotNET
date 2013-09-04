/* 9. We are given a string containing a list of forbidden words and a text containing
 * some of these words. Write a program that replaces the forbidden words with asterisks.
 *  Example:
 *      Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and
 *      is implemented as a dynamic language in CLR.
 *  Words: "PHP, CLR, Microsoft"
 *  The expected result:
 *      ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and
 *      is implemented as a dynamic language in ***. *  
*/

using System;

namespace _09.ForbiddenWordsReplacement
{
    class ForbiddenWordsReplacement
    {
        static void Main()
        {
            Console.WriteLine("Enter some text:");
            //string text = Console.ReadLine();
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            Console.WriteLine("Enter forbidden words, separated only by comma. Example: PHP,CLR,Microsoft");
            //string forbiddenWords = Console.ReadLine();
            string forbidden = "PHP,CLR,Microsoft";
            
            string[] forbiddenWords = forbidden.Split(',');
            string[] allWords = text.Split(' ');
            string newText = text;

            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                forbiddenWords[i] = forbiddenWords[i].Trim();
                string newWord = new String('*', forbiddenWords[i].Length);
                newText = newText.Replace(forbiddenWords[i], newWord);
            }

            Console.WriteLine("\nResult:");
            Console.WriteLine(newText);
        }
    }
}
