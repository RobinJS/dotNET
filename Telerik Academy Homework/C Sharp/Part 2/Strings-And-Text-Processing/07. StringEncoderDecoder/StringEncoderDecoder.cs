/* 7. Write a program that encodes and decodes a string using given encryption 
 * key (cipher). The key consists of a sequence of characters. The encoding/decoding
 * is done by performing XOR (exclusive or) operation over the first letter of the string
 * with the first of the key, the second – with the second, etc. When the last key 
 * character is reached, the next is the first.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace _07.StringEncoderDecoder
{
    class StringEncoderDecoder
    {
        static void Main()
        {
            string text = "";
            string key = "";

            while (text.Length < 1 && key.Length < 1)
            {
                Console.WriteLine("Enter text to be encrypted/decrypted:");
                text = Console.ReadLine();

                if (text.Length < 1)
                {
                    Console.WriteLine("The text is too short. It must be at least 1 character.");
                    continue;
                }

                Console.WriteLine("Enter encryption/decryption key:");
                key = Console.ReadLine();

                if (key.Length < 1)
                {
                    Console.WriteLine("The key is too short. It must be at least 1 character.");
                    continue;
                }
            }

            List<char> newChars = new List<char>();
            int keyLength = key.Length;

            int keyChar = 0;
            for (int ch = 0; ch < text.Length; ch++)
            {
                if (keyChar == keyLength)
                {
                    keyChar = 0;
                }

                char resultChar = (char)(text[ch] ^ key[keyChar]);

                newChars.Add(resultChar);
                keyChar++;
            }

            StringBuilder newText = new StringBuilder();
            foreach (char ch in newChars)
            {
                newText.Append(ch.ToString());
            }

            Console.WriteLine("The encrypted text is inside the brackets:"); // I put the result in brackets so if there is any white space, it will be obvious
            Console.WriteLine("[{0}]", newText);
        }
    }
}
