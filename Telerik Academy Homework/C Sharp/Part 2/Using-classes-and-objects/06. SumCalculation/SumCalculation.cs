// 6. You are given a sequence of positive integer values written into a string, separated by spaces. Write a function that reads these values from given string and calculates their sum. Example:
//		string = "43 68 9 23 318"  result = 461

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumCalculation
{
    class SumCalculation
    {
        static void Main()
        {
            Console.WriteLine("Enter a sequence of positive integer values, separated by spaces like so: 43 68 9 23 318 to find their sum:");
            string integersString = Console.ReadLine();
            //string integersString = "43 68 9 23 318";

            string[] integers = integersString.Split(' ');
            long sum = 0;

            foreach (string integer in integers)
            {
                sum += int.Parse(integer);
            }

            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
