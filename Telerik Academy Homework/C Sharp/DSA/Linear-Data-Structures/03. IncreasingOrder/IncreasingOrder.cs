//Write a program that reads a sequence of integers (List<int>) ending with
// an empty line and sorts them in an increasing order.

using System;
using System.Collections.Generic;

namespace _3.IncreasingOrder
{
    class IncreasingOrder
    {
        static void Main()
        {
            Console.WriteLine("Enter one by one as much integer numbers as you want. When you finish, press enter without typing any number.");
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
                    if (int.TryParse(input, out currentNumber) == true)
                    {
                        listOfNumbers.Add(currentNumber);
                    }
                    else
                    {
                        Console.WriteLine("Please, enter an integer number!");
                    }
                }
            }

            listOfNumbers.Sort();

            Console.WriteLine("The list of integers in inreasing order:");
            foreach (var item in listOfNumbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
