// 1. Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

namespace _01.LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            Console.WriteLine("Enter a year. Example: 2012");
            int year = int.Parse(Console.ReadLine());
            int month = 2;
            int day = 29;

            try
            {
                DateTime userYear = new DateTime(year, month, day);
                Console.WriteLine("This year is leap.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("This year is not leap.");
            }
        }
    }
}
