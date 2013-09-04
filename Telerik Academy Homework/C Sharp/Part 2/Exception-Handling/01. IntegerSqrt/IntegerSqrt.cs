// 1. Write a program that reads an integer number and calculates and prints
//  its square root. If the number is invalid or negative, print "Invalid number". 
//  In all cases finally print "Good bye". Use try-catch-finally.

using System;

namespace Exception_Handling
{
    class IntegerSqrt
    {
        static void Main()
        {
            Console.WriteLine("Please, enter an integer number: ");
            uint number = 0;

            try
            {
                number = uint.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
