//2. Write a program that extracts from a given sequence of strings all elements that present in it odd number of times.
//  Example: {C#, SQL, PHP, PHP, SQL, SQL } -> {C#, SQL}

using System;
using System.Collections.Generic;

namespace _2.OddStringElementsExtraction
{
    class OddStringElementsExtraction
    {
        static void Main()
        {
            string[] elements = { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            Console.Write("Sequence of elements: ");
            foreach (string el in elements)
            {
                Console.Write("{0} ", el);
            }
            Console.WriteLine();

            Dictionary<string, int> occurances = new Dictionary<string, int>();

            foreach (string element in elements)
            {
                if (!occurances.ContainsKey(element))
                {
                    occurances.Add(element, 0);
                }
                occurances[element]++;
            }

            Console.Write("All elements that present in the sequence odd number of times: ");
            foreach (KeyValuePair<string, int> pair in occurances)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.Write("{0} ", pair.Key);
                }
            }
            Console.WriteLine( );
        }
    }
}
