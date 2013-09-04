// 2. Write a method ReadNumber(int start, int end) that enters an integer number
//  in given range [start…end]. If an invalid number or non-number text is entered, 
//  the method should throw an exception. Using this method write a program that 
//  enters 10 numbers:  a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;
using System.Collections.Generic;

namespace _02.NumbersInRange
{
    class NumbersInRange
    {
        static void Main()
        {
            int start = 1;
            int end = 100;

            ReadNumber(start, end);
        }

        private static void ReadNumber(int start, int end)
        {
            Console.WriteLine("Please, enter 10 integer numbers between 1 and 100 so that each next number is bigger that the previous.");

            List<int> numbers = new List<int>();
            int currentNumber = 0;
            int previousNumber = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Int {0}: ", i);
                try
                {
                    currentNumber = int.Parse(Console.ReadLine());
                    if (currentNumber <= 1 || 100 <= currentNumber)
                    {
                        Console.WriteLine("You must enter a number between 1 and 100.");
                        throw new System.ArgumentOutOfRangeException();
                    }
                    if (currentNumber <= previousNumber)
                    {
                        Console.WriteLine("You must enter a bigger number.");
                        throw new System.ArgumentOutOfRangeException();
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Invalid number!");
                    throw fe;
                }

                previousNumber = currentNumber;
                numbers.Add(currentNumber);
            }
        }
    }
}
