/* 5. You are given a text. Write a program that changes the text
 * in all regions surrounded by the tags <upcase> and </upcase> to uppercase.
 * The tags cannot be nested.
 *  Example:
 *      We are living in a <upcase>yellow submarine</upcase>. We don't 
 *      have <upcase>anything</upcase> else.
 *      
 *  The expected result:
 *      We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
 */

using System;
using System.Text;

namespace _05.TextInTagsUpperCase
{
    class TextInTagsUpperCase
    {
        static void Main()
        {
            Console.WriteLine("Enter some text with words or phrases surrounded by <upcase> and </upcase> tags. The tags cannot be nested:");
            string text = Console.ReadLine();
            //string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            
            int startIndex = 0;
            int length = 0;
            StringBuilder newText = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (ch == '<' && text[i + 1] == 'u')   // if this is the beginning of the opening tag
                {
                    if (startIndex == 0)
                    {
                        length = i - startIndex;
                        newText.Append(text.Substring(startIndex, length)); // appending with the text before the first <upcase> tag
                    }
                    else
                    {
                        length = i - startIndex;
                        newText.Append(text.Substring(startIndex, length)); // appending with the text betweeen </upcase> and <upcase> tag
                    }
                }

                if (ch == '>' &&  text[i - 7] == '<')   // if this is the end of the opening tag
                {
                    startIndex = i + 1;
                    
                }

                if (ch == '<' && text[i + 1] == '/')    // if this is the beginning of the closing tag
                {
                    length = i - startIndex;
                    newText.Append(text.Substring(startIndex, length).ToUpper()); // appending with the text inside tags
                }

                if (ch == '>' && text[i - 7] == '/')    // if this is the end of the closing tag
                {
                    startIndex = i + 1;
                }

                if (i == text.Length - 1)
                {
                    length = text.Length - startIndex;
                    newText.Append(text.Substring(startIndex, length)); // appending with the rest of the text after all tags
                }
            }

            Console.WriteLine(newText);
        }
    }
}
