// Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example: 	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;
using System.Collections.Generic;

class ElementsVariations
{
    static void Main()
    {
        Console.Write("Enter a number for N: ");
        int N = 3;//int.Parse(Console.ReadLine());
        Console.Write("Enter a number for K: ");
        int K = 4;//int.Parse(Console.ReadLine());
        Console.WriteLine();

        // creating elements
        List<int> elements = new List<int>();
        for (int i = 0; i < K; i++)
        {
            elements.Add(1);
        }

        try
        {
            while (true)
            {
                int currentIndex = K - 1;

                // printing elements
                Console.Write("{");
                foreach (int item in elements)
                {
                    Console.Write("{0}, ", item);
                }
                Console.Write("\b\b}");
                Console.WriteLine();

                // creating variations
                while (elements[currentIndex] == N)
                {
                    elements[currentIndex] = 1;
                    currentIndex -= 1;
                }

                elements[currentIndex]++;
                currentIndex = K - 1;
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine();
        }
    }
}
