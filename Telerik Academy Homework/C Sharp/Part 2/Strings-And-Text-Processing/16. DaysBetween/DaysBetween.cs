/* 12. Write a program that reads two dates in the format: day.month.year and
 * calculates the number of days between them.
 *  Example:
 *      Enter the first date: 27.02.2006
 *      Enter the second date: 3.03.2006
 *      Distance: 4 days
 */

using System;

namespace _16.DaysBetween
{
    class DaysBetween
    {
        static void Main()
        {
            Console.WriteLine("Enter the first date in the format: day.month.year ");
            string[] firstDate = Console.ReadLine().Split('.');
            Console.WriteLine("Enter the second date in the format: day.month.year: ");
            string[] secondDate = Console.ReadLine().Split('.');

            DateTime one = new DateTime(int.Parse(firstDate[2]), int.Parse(firstDate[1]), int.Parse(firstDate[0]));
            DateTime two = new DateTime(int.Parse(secondDate[2]), int.Parse(secondDate[1]), int.Parse(secondDate[0]));

            TimeSpan distance = two - one;
            Console.WriteLine("Distance: {0} days", distance.Days);
        }
    }
}
