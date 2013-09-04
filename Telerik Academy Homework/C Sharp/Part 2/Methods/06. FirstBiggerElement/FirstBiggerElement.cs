//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class FirstBiggerElement
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

        int[] arrInt = { 5, 8, 17, 3, 6, 9, 4 };

        int result = ElementCheck(arrInt);

        PrintResult(result);
    }

    static int ElementCheck(int[] arrInt)
    {

        for (int elementToCheck = 0; elementToCheck < arrInt.Length; elementToCheck++)
        {
            if (elementToCheck == 0)    // if the elements is at zero position
            {
                if (arrInt[elementToCheck] > arrInt[elementToCheck + 1])
                {
                    return 0;
                    break;
                }
            }

            else if (elementToCheck == arrInt.Length - 1)   // if the element is the last
            {
                if (arrInt[elementToCheck] > arrInt[elementToCheck - 1])
                {
                    return arrInt.Length - 1;
                    break;
                }
            }
            else
            {
                if (arrInt[elementToCheck] > arrInt[elementToCheck - 1] && arrInt[elementToCheck] > arrInt[elementToCheck + 1])
                {
                    return elementToCheck;
                    break;
                }
            }
        }
        return -1;
    }

    static void PrintResult(int result)
    {
        if (result >= 0)
        {
            Console.WriteLine("Element with index [{0}] is the first that is bigger than its neighbors.", result);
        }
        else
        {
            Console.WriteLine("There is no element bigger than its neighbours.");
        }
    }
}
