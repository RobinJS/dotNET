using System;
using System.Numerics;

class FactorialsMultyplication
{
    static void Main()
    {
        Console.WriteLine("To calculate the equation N!*K! / (K-N)! you must enter two integers for N and K according to the rule: (1<N<K).\r\nEnter a number for N:");
        int userN;
        do
        {
            bool checkN = Int32.TryParse(Console.ReadLine(), out userN);
            if (userN <= 1)
            {
                Console.WriteLine("You must enter an integer number > 1");
            }
        }
        while (userN <= 1);
        Console.WriteLine("Now, enter a number for K:");
        int userK;
        do
        {
            bool checkK = Int32.TryParse(Console.ReadLine(), out userK);
            if (userK <= userN)
            {
                Console.WriteLine("You must enter an integer number > N");
            }
        }
        while (userK <= userN);

        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialKN = 1;
        int substraction = userK - userN;

        do
        {
            factorialN *= userN;
            userN--;
        }
        while (userN > 0);

        do
        {
            factorialK *= userK;
            userK--;
        }
        while (userK > 0);

        do
        {
            factorialKN *= substraction;
            substraction--;
        }
        while (substraction > 0);

        BigInteger calculation = (factorialN * factorialK) / factorialKN;
        Console.WriteLine("N!*K! / (K-N)! = " + calculation);
    }
}
