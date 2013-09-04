//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BinSearch
{
    static void Main()
    {
        //Console.WriteLine("Enter length for array of integers :");
        //int N = int.Parse(Console.ReadLine());
        //int[] arrInt = new int[N];
        int[] arrInt = { 20, 40, 60, 80, 90 };

        //for (int i = 0; i < arrInt.Length; i++)
        //{
        //    Console.Write("Enter element [{0}] of the array: ", i);
        //    arrInt[i] = int.Parse(Console.ReadLine());
        //}

        //Console.Write("To find the largest number in the array which is <= K, enter K:");
        int K = 500;//int.Parse(Console.ReadLine());

        Array.Sort(arrInt);

        Console.WriteLine("Array sorted:");
        foreach (int number in arrInt)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine("\n");

        int maxValue = arrInt.Max();
        int minValue = arrInt.Min();

        if (K < minValue)
        {
            Console.WriteLine("There is no number <= K.");
        }
        else if (K >= maxValue)
        {
            Console.WriteLine("The largest number <= K is {0} at index [{1}].", maxValue, arrInt.Length - 1);
        }
        else
        {
            for (int i = 0; i < K; i++)
            {
                int search = Array.BinarySearch(arrInt, K - i);
                if (search >= 0)
                {
                    Console.WriteLine("The largest number <= K is {0} at index [{1}].", K - i, search);
                    break;
                }
            }
        }
    }
}
