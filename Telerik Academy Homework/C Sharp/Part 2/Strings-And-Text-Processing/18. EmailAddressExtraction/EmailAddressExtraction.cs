/*18. Write a program for extracting all email addresses from given text.
 * All substrings that match the format <identifier>@<host>…<domain> 
 * should be recognized as emails.*/

using System;
using System.Text.RegularExpressions;

namespace _18.EmailAddressExtraction
{
    class EmailAddressExtraction
    {
        static void Main()
        {
            Console.WriteLine("Enter some text to extract emails from:");
            //string text = Console.ReadLine();
            string text = "some text pesho@gosho.com more text pesho_gosho@mimi.bg many more text here pesho.gosho@mimi.bg maby some simbols like @#$% 135 pesho_gosho.mimi@somewherein.fr bai-gencho-91@nematakuv.domain end";
            string[] testSplitted = text.Split(' ');
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            Console.WriteLine("All emails:");

            foreach (string part in testSplitted)
            {
                if (Regex.IsMatch(part, pattern))
                {
                    Console.WriteLine(part);
                }
            }
        }
    }
}
