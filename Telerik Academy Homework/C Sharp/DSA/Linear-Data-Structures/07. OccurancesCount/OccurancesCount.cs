//Write a program that finds in given array of integers (all belonging to the range [0..1000])
// how many times each of them occurs.
//Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
// 2 -> 2 times
// 3 -> 4 times
// 4 -> 3 times

using System;
using System.Collections.Generic;

namespace _7.OccurancesCount
{
    class OccurancesCount
    {
        static void Main()
        {
            List<int> numbers = new List<int>{ 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            int counter = 0;
            int indexToCompare = 0;

            while (indexToCompare != numbers.Count)
            {
                for (int currenIndex = 0; currenIndex < numbers.Count; currenIndex++)
                {
                    if (numbers[currenIndex] == numbers[indexToCompare])
                    {
                        counter++;
                    }
                }

                Console.WriteLine("Number {0} appears {1} times.", numbers[indexToCompare], counter);

                int numberToRemove = numbers[indexToCompare];
                numbers.RemoveAll(item => item == numberToRemove);
                counter = 0;
            }
        }
    }
}
