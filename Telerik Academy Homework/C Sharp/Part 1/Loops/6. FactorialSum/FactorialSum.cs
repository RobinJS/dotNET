using System;

class FactorialSum
{
    static void Main()
    {
        Console.WriteLine("To calculate the equation S = 1 + 1!/X + 2!/X^2 + … + N!/X^N enter positive integer numbers for N and for X.");
        Console.WriteLine("Enter a number for N: ");
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number for X: ");
        double x = double.Parse(Console.ReadLine());

        double factorialN = 1;
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            double xPow = (double)Math.Pow(x, i);
            double division = factorialN / xPow;
            sum += division;
        }
        Console.WriteLine("Result: {0}", sum);
    }
}
