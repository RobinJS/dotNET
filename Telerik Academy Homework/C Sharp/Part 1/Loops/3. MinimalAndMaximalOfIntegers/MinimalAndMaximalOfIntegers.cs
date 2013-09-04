using System;

class MinimalAndMaximalOfIntegers
{
    static void Main()
    {
        Console.WriteLine("This program will show you the minimal and the maximal of sequence of integer numbers.\r\nPlease enter how many numbers would you like to compare: ");
        int nCount;
        int currentNum;
        bool current = true;
        bool userNumers;
        int maxNum = int.MinValue;
        int minNum = int.MaxValue;
        do
        {
            userNumers = Int32.TryParse(Console.ReadLine(), out nCount);
            if (userNumers == false || nCount < 2)
            {
                Console.WriteLine("Please, enter a positive integer number > 1:");
            }
            else
            {
                while (true)
                {
                    for (int i = 1; i <= nCount; i++)
                    {
                        Console.Write("Enter your digit #{0}: ", i);
                        current = Int32.TryParse(Console.ReadLine(), out currentNum);
                        if (current == false || nCount < 0)
                        {
                            Console.WriteLine("Please, enter an integer number.");
                            break;
                        }
                        else
                        {
                            if (currentNum > maxNum)
                            {
                                maxNum = currentNum;
                            }
                            if (currentNum < minNum)
                            {
                                minNum = currentNum;
                            }
                        }
                    }   // end of for

                    if (current == true)
                    {
                        Console.WriteLine("\r\nResult: Min = {0}, Max = {1}", minNum, maxNum);
                        break;
                    }
                }   // end of while
            }   // end of else
        }   // end of do
        while (userNumers == false);
    }
}