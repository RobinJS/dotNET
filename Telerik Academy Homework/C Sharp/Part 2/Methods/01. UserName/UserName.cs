// Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.UserName
{
    class UserName
    {
        static void Main()
        {
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();


            bool isValid = Validate(userName);

            if (isValid)
            {
                PrintUserName(userName);
            }
            else
            {
                Console.WriteLine("Incorrect input data!");
            }
        }

        static bool Validate(string userName)
        {

            string characters = @"0123456789`~!@#$%^&*()-_=+\\|[{]}'"";:/?.>,<";
            bool isValid = true;

            foreach (char ch in characters)
            {
                if (userName.IndexOf(ch) >= 0)
                {
                    isValid = false;
                }
            }
            return isValid;
        }

        static void PrintUserName(string userName)
        {
            Console.WriteLine("Hello, {0}!", userName);
        }
    }
}
