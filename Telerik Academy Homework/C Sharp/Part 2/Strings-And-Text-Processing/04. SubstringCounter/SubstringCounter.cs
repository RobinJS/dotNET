/* 4. Write a program that finds how many times a substring is contained 
 * in a given text (perform case insensitive search).
 *  Example: The target substring is "in". The text is as follows:
 *      We are living in an yellow submarine. We don't have anything else. 
 *      Inside the submarine is very tight. So we are drinking all the day. 
 *      We will move out of it in 5 days.
 *  
 *  The result is: 9.
 */

using System;

namespace _04.SubstringCounter
{
    class SubstringCounter
    {
        static void Main()
        {
            Console.WriteLine("Enter some text:");
            string text = Console.ReadLine();
            //string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            Console.WriteLine("Enter a substring to search for:");
            string substr = Console.ReadLine();
            //string substr = "in";

            int count = 0;
            int index = 0;
            while (index != -1)
            {
                index = text.IndexOf(substr, index + 1);
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
