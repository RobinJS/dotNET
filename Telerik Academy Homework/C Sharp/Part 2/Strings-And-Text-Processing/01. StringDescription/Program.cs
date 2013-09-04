/*1. Describe the strings in C#. What is typical for the string data type? Describe the most important methods of the String class.*/

using System;

namespace _01.StringDescription
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Strings are immutable data types similar to array of chars. They have length and each char can be accessed by it's index. One of the most used string methods is the String.Substring Method which extracts part of the string. Another popular method is String.ToLower Method which retunrs all characters in a given string to lower case. Similar to this method is the String.ToUpper Method which returns new string all with capitla letters.");
            Console.WriteLine("The String.Split Method is another method which splits the string into pieces by given character separator.");
            Console.WriteLine("The String.IndexOf Method returns a numeral value representing index of the first occurrence of the specified string.");
        }
    }
}
