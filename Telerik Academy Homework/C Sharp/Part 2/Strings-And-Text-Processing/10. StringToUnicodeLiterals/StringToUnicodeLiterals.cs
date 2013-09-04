/* 10. Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.
 * Sample input:
 *      Hi!
 *      Expected output:
 *      \u0048\u0069\u0021
 */

using System;

namespace _10.StringToUnicodeLiterals
{
    class StringToUnicodeLiterals
    {
        static void Main()
        {
            Console.WriteLine("Enter some text:");
            string text = Console.ReadLine();
            //string text = "Hi!";

            Console.WriteLine("Your text as Unicode character literal:");
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write("\\u{0:x4}", (int)text[i]);
            }

            Console.WriteLine();
        }
    }
}
