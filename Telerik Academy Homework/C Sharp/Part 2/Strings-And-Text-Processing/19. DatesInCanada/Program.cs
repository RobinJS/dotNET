/*19. Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
 * Display them in the standard date format for Canada.*/

using System;
using System.Globalization;

namespace _19.DatesInCanada
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter some text containing dates in the format DD.MM.YYYY");
            string text = Console.ReadLine();
            //string text = "Welcome to Canada! Today is 23.05.2006. The weather is fine, but it gets cold at 24.12.2006.";

            string[] dates = text.Split(' ');

            foreach (string date in dates)
            {
                if (date.Length >= 9 && date[2] == '.' && date[5] == '.')
                {
                    int day = 0;
                    int month = 0;
                    int year = 0;
                    string d = date.Substring(0, 2);
                    string m = date.Substring(3, 2);
                    string y = date.Substring(6, 4);

                    if (int.TryParse(d, out day) && int.TryParse(m, out month) && int.TryParse(y, out year))
                    {
                        DateTime currentDate = new DateTime(year, month, day);
                        Console.WriteLine(currentDate.ToString(CultureInfo.GetCultureInfo("en-CA")));
                    }
                }
            }
        }
    }
}
