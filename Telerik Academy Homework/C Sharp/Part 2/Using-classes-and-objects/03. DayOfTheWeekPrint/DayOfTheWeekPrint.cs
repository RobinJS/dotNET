// 3. Write a program that prints to the console which day of the week is today.
//  Use System.DateTime.

using System;

namespace _03.DayOfTheWeekPrint
{
    class DayOfTheWeekPrint
    {
        static void Main()
        {
            Console.Write("Today is: ");
            DateTime today = DateTime.Today;
            Console.WriteLine(today.DayOfWeek);
        }
    }
}
