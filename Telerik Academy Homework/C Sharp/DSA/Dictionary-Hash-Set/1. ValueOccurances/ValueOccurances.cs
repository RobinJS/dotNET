//1. Write a program that counts in a given array of double values the number of occurrences of each value. Use Dictionary<TKey,TValue>.
//  Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
//      -2.5 -> 2 times
//      3 -> 4 times
//      4 -> 3 times

using System;
using System.Collections.Generic;

namespace _1.ValueOccurances
{
    class ValueOccurances
    {
        static void Main()
        {
            double[] numbers = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            Console.Write("Array of double values: ");
            foreach (double number in numbers)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();

            Dictionary<double, int> occurances = new Dictionary<double, int>();

            foreach (double number in numbers)
            {
                if (!occurances.ContainsKey(number))
                {
                    occurances.Add(number, 0);
                }
                occurances[number]++;
            }

            foreach (KeyValuePair<double, int> pair in occurances)
            {
                Console.WriteLine("{0} has {1} occurances", pair.Key, pair.Value);
            }
        }
    }
}
