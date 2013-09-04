using System;

class FactorialsDivision
{
    static void Main()
    {
        Console.WriteLine("To calculate the equation N!/K! you must enter two integers for N and K according to the rule: (1<K<N).\r\nEnter a number for K:");
        int userK;
        do
        {
            bool checkK = Int32.TryParse(Console.ReadLine(), out userK);
            if (userK <= 1)
            {
                Console.WriteLine("You must enter an integer number > 1");
            }
        }
        while (userK <= 1);
        Console.WriteLine("Now, enter a number for N:");
        int userN;
        do
        {
            bool checkN = Int32.TryParse(Console.ReadLine(), out userN);
            if (userN <= userK)
            {
                Console.WriteLine("You must enter an integer number > K");
            }
        }
        while (userN <= userK);

        int factorialN = 1;
        int factorialK = 1;
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

        int division = factorialN / factorialK;
        Console.WriteLine("N!/K! = " + division);
    }
}
