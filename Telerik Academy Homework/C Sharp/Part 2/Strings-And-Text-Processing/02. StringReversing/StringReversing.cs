/* 1. Write a program that reads a string, reverses it and prints the result 
 * at the console. Example: "sample" -> "elpmas".
 */

using System;

namespace _02.StringReversing
{
    class StringReversing
    {
        static void Main()
        {
            Console.WriteLine("Enter some text or a word:");
            string input = Console.ReadLine();

            Console.WriteLine("\nReversed:");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }

            Console.WriteLine();
        }
    }
}
