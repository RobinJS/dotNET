//Write a program that reads N integers from the console and reverses them using a stack. Use the Stack<int> class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ReversedIntegers
{
    class ReversedIntegers
    {
        static void Main()
        {
            int integersToRead = 0;
            while (integersToRead <= 0)
            {
                Console.Write("Number of integers to read? ");
                string inputN = Console.ReadLine();

                if (int.TryParse(inputN, out integersToRead) == true && integersToRead > 0)
                {
                    Stack<int> listOfNumbers = new Stack<int>();

                    for (int i = 0; i < integersToRead; i++)
                    {
                        while (true)
                        {
                            string integer = Console.ReadLine();

                            int currentNumber;
                            if (int.TryParse(integer, out currentNumber) == true)
                            {
                                listOfNumbers.Push(currentNumber);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please, enter an integer number!");
                            }
                        }
                    }

                    Console.WriteLine();
                    foreach (int number in listOfNumbers)
                    {
                        Console.WriteLine(number);
                    }
                }
                else
                {
                    Console.WriteLine("Please, enter a positive integer number!");
                }
            }
        }
    }
}
