/* 17. Write a program that reads a date and time given 
 * in the format: day.month.year hour:minute:second 
 * and prints the date and time after 6 hours and 30 minutes (in the same format) 
 * along with the day of week in Bulgarian.
 */

using System;
using System.Globalization;

namespace _17.DateTimeAfter
{
    class DateTimeAfter
    {
        static void Main()
        {
            Console.WriteLine("Enter date in the format: day.month.year hour:minute:second ");
            //string[] currentDate = Console.ReadLine().Split('.', ' ', ':');
            string[] currentDate = "15.11.1247 15:23:44".Split('.', ' ', ':');

            DateTime date = new DateTime(int.Parse(currentDate[2]), int.Parse(currentDate[1]), int.Parse(currentDate[0]), int.Parse(currentDate[3]), int.Parse(currentDate[4]), int.Parse(currentDate[5]));
            date = date.AddHours(6).AddMinutes(30);

            Console.WriteLine(date + " {0}", date.ToString("dddd", new CultureInfo("bg-BG")));
        }
    }
}
