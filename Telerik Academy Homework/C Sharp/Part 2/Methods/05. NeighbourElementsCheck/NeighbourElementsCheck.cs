// Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class NeighbourElementsCheck
{
    static void Main()
    {
        //Console.WriteLine("To create an array, first enter its length: ");
        //int arrLength = int.Parse(Console.ReadLine());

        //int[] arrInt = new int[arrLength];

        //for (int i = 0; i < arrLength; i++)
        //{
        //    Console.Write("Enter element [{0}] of the array: ", i);
        //    arrInt[i] = int.Parse(Console.ReadLine());
        //}
        //Console.WriteLine();

        int[] arrInt = { 5, 8, 17, 9, 2, 6, 4 };

        //Console.WriteLine("Which position would you like to check (from zero to {0})? ", arrInt.Length - 1);
        int elementToCheck = 2;// int.Parse(Console.ReadLine());

        ElementCheck(arrInt, elementToCheck);

    }

    static void ElementCheck(int[] arrInt, int elementToCheck)
    {
        try
        {
            if (elementToCheck == 0)    // if the elements is at zero position
            {
                Console.Write("This element has only one neihgbour and is ");
                if (arrInt[elementToCheck] > arrInt[elementToCheck + 1])
                {
                    Console.WriteLine("bigger than its neighbour.");
                }
                else if (arrInt[elementToCheck] < arrInt[elementToCheck + 1])
                {
                    Console.WriteLine("smaller than its neighbour.");
                }
                else
                {
                    Console.WriteLine("equal to its neighbour.");
                }
            }

            else if (elementToCheck == arrInt.Length - 1)   // if the element is the last
            {
                Console.Write("This element has only one neihgbour and is ");
                if (arrInt[elementToCheck] > arrInt[elementToCheck - 1])
                {
                    Console.WriteLine("bigger than its neighbour.");
                }
                else if (arrInt[elementToCheck] < arrInt[elementToCheck - 1])
                {
                    Console.WriteLine("smaller than its neighbour.");
                }
                else
                {
                    Console.WriteLine("equal to its neighbour.");
                }
            }
            else
            {
                if (arrInt[elementToCheck] > arrInt[elementToCheck - 1] && arrInt[elementToCheck] > arrInt[elementToCheck + 1])
                {
                    Console.WriteLine("The element is bigger than its neighbours.");
                }
                else if (arrInt[elementToCheck] < arrInt[elementToCheck - 1] && arrInt[elementToCheck] < arrInt[elementToCheck + 1])
                {
                    Console.WriteLine("The element is smaller than its neighbours.");
                }
                else
                {
                    Console.WriteLine("The element is equal to one or to both of its neighbours.");
                }
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("There is no element at this position!");
        }
    }
}
