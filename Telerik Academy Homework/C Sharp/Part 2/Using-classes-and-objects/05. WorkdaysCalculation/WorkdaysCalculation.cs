// 5. Write a method that calculates the number of workdays between today and given date, 
//  passed as parameter. Consider that workdays are all days from Monday to Friday except a fixed list of 
//  public holidays specified preliminary as array.

using System;
using System.Linq;

namespace _05.WorkdaysCalculation
{
    class WorkdaysCalculation
    {
        static void Main()
        {
            Console.WriteLine("To calculate the working days between today and another date (excluding these two dates), please enter a date (Example: 01.06.2012).");
            string inputDate = Console.ReadLine();
            int workdays = calculateWorkdays(inputDate);
            Console.WriteLine("Working days: {0}", workdays);
        }

        public static int calculateWorkdays(string inputDate)
        {
            int days = 0;
            string[] userDate = inputDate.Split('.');
            int userYear = int.Parse(userDate[2]);
            int userMonth = int.Parse(userDate[1]);
            int userDay = int.Parse(userDate[0]);

            DateTime dateToCompare = new DateTime(userYear, userMonth, userDay);
            DateTime today = DateTime.Today;

            string[] publicHolidays = {
                "1.1", "3.3", "1.5", "6.5", "24.5", "6.9", "22.9", "1.11", "24.12", "25.12", "26.12"
            };

            int allDaysBetween = 0;
            bool todayIsBigger = today > dateToCompare;
            bool dateToCompareIsBigger = dateToCompare > today;

            if (todayIsBigger)
            {
                allDaysBetween = (today - dateToCompare).Days;
            }
            else if (dateToCompareIsBigger)
            {
                allDaysBetween = (dateToCompare - today).Days;
            }

            for (int i = 0; i < allDaysBetween; i++)
            {
                string currentDate = dateToCompare.Day + "." + dateToCompare.Month;
                bool isSaturday = (dateToCompare.DayOfWeek).ToString() == "Saturday";
                bool isSunday = (dateToCompare.DayOfWeek).ToString() == "Sunday";

                if (!publicHolidays.Contains(currentDate) && !isSaturday && !isSunday)
                {
                    days++;
                }

                if (todayIsBigger)
                {
                    dateToCompare = dateToCompare.AddDays(1);
                }
                else if (dateToCompareIsBigger)
                {
                    dateToCompare = dateToCompare.AddDays(-1);
                }
            }

            // In order to find the workdays excluding today and the given date, we need to extract "1"
            return days - 1;
        }
    }
}
