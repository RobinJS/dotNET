using System;
using System.Numerics;

class CatalanNumber
{
    static void Main()
    {
        Console.WriteLine("To calculate the Nth Catalan number, please enter a positive integer number for N: ");
        int userN;
        do
        {
            bool checkN = Int32.TryParse(Console.ReadLine(), out userN);
            if (userN < 0)
            {
                Console.WriteLine("You must enter an integer number");
            }
        }
        while (userN < 0);

        int nByTwo = 2 * userN;
        BigInteger factorial2N = 1;
        while (nByTwo > 0)
        {
            factorial2N *= nByTwo;
            nByTwo--;
        }   // now we have (2n)!

        int nPlusOne = userN + 1;
        BigInteger factorialNplusOne = 1;
        while (nPlusOne > 0)
        {
            factorialNplusOne *= nPlusOne;
            nPlusOne--;
        }   // now we have (n + 1)!

        BigInteger factorialN = 1;
        while (userN > 0)
        {
            factorialN *= userN;
            userN--;
        }   // now we have n!

        BigInteger equation = factorial2N / (factorialNplusOne * factorialN);
        Console.WriteLine("The Nth Catalan number is " + equation);
    }
}
