using System;

class Matrix
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer number < 20:");
        int userN;
        do
        {
            bool checkN = Int32.TryParse(Console.ReadLine(), out userN);
            if (userN < 1 || userN >= 20)
            {
                Console.WriteLine("You must enter an integer number bigger than 0 and less than 20.");
            }
        }
        while (userN < 1 || userN >= 20);

        Console.WriteLine("You have just created the following matrix:");
        for (int i = 1; i <= userN; i++)
        {
            for (int j = i; j <= i + userN - 1; j++)
            {
                Console.Write(" {0,-2} ", j);
            }
            Console.WriteLine();
        }
    }
}
