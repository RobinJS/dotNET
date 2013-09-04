// Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Extension_Methods
{
    public static class IEnumExtentions
    {
        public static void Calculate<T>(this IEnumerable<T> iEnum)
        {
            // calculating Sum
            double sum = 0;
            foreach (var number in iEnum)
            {
                sum += double.Parse(number.ToString());
            }
            Console.WriteLine(sum);

            // calculating Product
            double product = 1;
            foreach (var number in iEnum)
            {
                product *= double.Parse(number.ToString());
            }
            Console.WriteLine(product);

            // calculating Min
            Console.WriteLine(iEnum.Min());

            // calculating Max
            Console.WriteLine(iEnum.Max());

            // calculating Average
            Console.WriteLine(sum / iEnum.Count());
        }
    }
    class ExtensionMethods
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 5, 10, 50, 100 };
            numbers.Calculate();
        }
    }
}
