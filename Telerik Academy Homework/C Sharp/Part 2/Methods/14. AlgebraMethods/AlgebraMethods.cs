// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class AlgebraMethods
{
    static void Main()
    {
        int a = 5;
        int b = -8;
        int c = 1;
        int d = 9;
        int e = -6;

        int minimum = CalculateMinimum(a, b, c, d, e);
        Console.WriteLine("Minimal number: {0}", minimum);

        int maximum = CalculateMaximum(a, b, c, d, e);
        Console.WriteLine("Maximal number: {0}", maximum);

        decimal average = CalculateAverage(a, b, c, d, e);
        Console.WriteLine("Average: {0}", average);

        int sum = CalculateSum(a, b, c, d, e);
        Console.WriteLine("Sum: {0}", sum);

        int product = CalculateProduct(a, b, c, d, e);
        Console.WriteLine("Product: {0}", product);
    }

    static int CalculateMinimum(params int[] numbers)
    {
        return numbers.Min();
    }

    static int CalculateMaximum(params int[] numbers)
    {
        return numbers.Max();
    }

    static decimal CalculateAverage(params int[] numbers)
    {
        decimal average = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            average += numbers[i];
        }

        average = average / numbers.Length;
        return average;
    }

    static int CalculateSum(params int[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    static int CalculateProduct(params int[] numbers)
    {
        int product = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }

        return product;
    }
}
