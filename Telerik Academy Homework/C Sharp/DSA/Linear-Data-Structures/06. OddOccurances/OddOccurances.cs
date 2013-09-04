//Write a program that removes from given sequence all numbers that occur odd number of times.
// Example: {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} -> {5, 3, 3, 5}

using System;
using System.Collections.Generic;

namespace _6.OddOccurances
{
    class OddOccurances
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            int counter = 0;
            int indexToCompare = 0;

            while (indexToCompare < numbers.Count)
            {
                for (int currenIndex = 0; currenIndex < numbers.Count; currenIndex++)
                {
                    if (numbers[currenIndex] == numbers[indexToCompare])
                    {
                        counter++;
                    }
                }

                if (counter % 2 != 0)
                {
                    int numberToRemove = numbers[indexToCompare];
                    numbers.RemoveAll(item => item == numberToRemove);
                }
                else
                {
                    indexToCompare++;
                }

                counter = 0;
            }

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
