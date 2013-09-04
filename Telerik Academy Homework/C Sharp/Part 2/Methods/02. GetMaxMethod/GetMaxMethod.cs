// Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class GetMaxMethod
{
    static void Main()
    {

        Console.Write("Integer 1: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Integer 2: ");
        int second = int.Parse(Console.ReadLine());
        Console.Write("Integer 3: ");
        int third = int.Parse(Console.ReadLine());

        int biggest = GetMax(first, second);
        biggest = GetMax(biggest, third);

        Console.WriteLine();
        Console.WriteLine("The biggest number is {0}", biggest);
    }

    static int GetMax(int one, int two)
    {
        if (one > two)
        {
            return one;
        }
        else if (one < two)
        {
            return two;
        }
        else
        {
            return one;
        }
    }
}