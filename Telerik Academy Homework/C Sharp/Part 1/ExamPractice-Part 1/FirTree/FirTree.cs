using System;

class FirTree
{
    static void Main()
    {
        
        int n = Int32.Parse(Console.ReadLine());

        string dot = ".";
        string asterisk = "*";
        int dotCountLeft = n - 2;
        int dotCountRight = n - 2;
        int astCount = 1;

        for (int row = 1; row < n; row++)
        {

            for (int ld = 1; ld <= dotCountLeft; ld++) // printing Left dots
            {
                Console.Write(dot);
            }
            dotCountLeft--;

            for (int a = 1; a <= astCount; a++) // printing *
            {
                Console.Write(asterisk);
            }
            astCount += 2;

            for (int rd = 1; rd <= dotCountRight; rd++) // printing Right dots
            {
                Console.Write(dot);
            }
            dotCountRight--;
            Console.WriteLine();
        }

        // printing stem
        for (int ld = 1; ld <= n - 2; ld++) // printing Left dots
        {
            Console.Write(dot);
        }

        Console.Write(asterisk);    // printing *

        for (int rd = 1; rd <= n - 2; rd++) // printing Right dots
        {
            Console.Write(dot);
        }
        Console.WriteLine();
    }
}
