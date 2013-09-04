/* 6. Write a program that reads from the console a string of maximum 20 characters.
 * If the length of the string is less than 20, the rest of the characters should be 
 * filled with '*'. Print the result string into the console.*/

using System;
using System.Text;

namespace _06.StringOfMax20Chars
{
    class StringOfMax20Chars
    {
        static void Main()
        {
            int textLength = int.MaxValue;

            while (textLength > 20)
            {
                Console.WriteLine("Enter a text no longer than 20 characters:");
                string text = Console.ReadLine();
                textLength = text.Length;

                if (textLength > 20)
                {
                    Console.WriteLine("Your text is too long. Try again:");
                }
                else if (textLength < 20)
                {
                    StringBuilder newText = new StringBuilder();
                    newText.Append(text);
                    int lengthTo20 = 20 - textLength;

                    for (int i = 0; i < lengthTo20; i++)
                    {
                        newText.Append("*");
                    }

                    Console.WriteLine(newText);
                    break;
                }
                else if (textLength == 20)
                {
                    Console.WriteLine("Your text is 20 characters.");
                }
            }
        }
    }
}
