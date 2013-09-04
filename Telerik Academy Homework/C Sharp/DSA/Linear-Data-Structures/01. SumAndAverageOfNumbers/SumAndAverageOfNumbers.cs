//Write a program that reads from the console a sequence of positive integer numbers.
//The sequence ends when empty line is entered. Calculate and print the sum and average of the elements of the sequence.
//Keep the sequence in List<int>.

using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAndAverageOfNumbers
{
    class SumAndAverageOfNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter one by one as much positive integer numbers as you want. When you finish, press enter without typing any number.");
            List<int> listOfNumbers = new List<int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                else
                {
                    int currentNumber;
                    if (int.TryParse(input, out currentNumber) == true && currentNumber > 0)
                    {
                        listOfNumbers.Add(currentNumber);
                    }
                    else
                    {
                        Console.WriteLine("Please, enter a positive integer number!");
                    }
                }
            }

            Console.WriteLine("The sum of the numbers is: ");
            double sum = 0;

            foreach (var number in listOfNumbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);

            Console.WriteLine("The average is: ");
            double average = listOfNumbers.Average();
            Console.WriteLine(average);
        }
    }
}
