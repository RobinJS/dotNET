// Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_Printing_Numbers
{
    class PrintingNumbers
    {
        static void Main()
        {
            int[] numbers = new int[] { 3, 7, 15, 21, 44, 35, 63, 10};

            Console.WriteLine("All numbers that are divisible by 7 and 3 with Lambda:");
            PrintNumbersLambda(numbers);
            Console.WriteLine();
            Console.WriteLine("All numbers that are divisible by 7 and 3 with LINQ:");

            PrintNumbersLINQ(numbers);
        }

        static void PrintNumbersLambda(int[] numbers)
        {
            var divisible = numbers.Where(x => x % 21 == 0);

            foreach (var num in divisible)
            {
                Console.WriteLine("{0}", num);
            }
        }

        static void PrintNumbersLINQ(int[] numbers)
        {
            var divisible =
                from number in numbers
                where (number % 21 == 0)
                select number;

            foreach (var num in divisible)
            {
                Console.WriteLine("{0}", num);
            }
        }
    }
}
