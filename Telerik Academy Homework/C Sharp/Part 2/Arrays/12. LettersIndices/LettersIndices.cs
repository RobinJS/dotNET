// Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.

using System;

class LettersIndices
{
    static void Main()
    {
        // reading a word
        Console.WriteLine("Enter a word:");
        string userWord = Console.ReadLine();

        userWord = userWord.ToUpper();  // To upper case, if not

        // creating Array with the letters
        char[] alphabet = new char[26];
        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = Convert.ToChar(i + 65);
        }

        // Evaluation and printing
        for (int i = 0; i < userWord.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (userWord[i] == alphabet[j])
                {
                    int index = j + 1;
                    Console.Write(index + " ");
                }
            }
        }
    }
}
