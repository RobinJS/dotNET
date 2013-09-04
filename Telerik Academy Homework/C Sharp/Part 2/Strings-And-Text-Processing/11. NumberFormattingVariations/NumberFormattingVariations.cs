/* 11. Write a program that reads a number and prints it as a decimal number, 
 * hexadecimal number, percentage and in scientific notation. Format the output
 * aligned right in 15 symbols.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumberFormattingVariations
{
    class NumberFormattingVariations
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer number:");
            //int number = int.Parse(Console.ReadLine());
            int number = 255;
            Console.WriteLine("Your number as decimal: {0,15:D}", number);
            Console.WriteLine("Your number as hexadecimal: {0,15:X}", number);
            Console.WriteLine("Your number as decimal: {0,15:P}", number);
            Console.WriteLine("Your number as decimal: {0,15:E}", number);

        }
    }
}
