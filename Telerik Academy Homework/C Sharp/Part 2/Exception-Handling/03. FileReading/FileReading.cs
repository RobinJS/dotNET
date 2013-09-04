// Write a program that enters file name along with its full file 
//  path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
//  Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible 
//  exceptions and print user-friendly error messages.

using System;
using System.IO;
using System.Security;

namespace _03.FileReading
{
    class FileReading
    {
        static void Main()
        {
            Console.WriteLine("Enter file path:");
            // You can find this file in "Debug" directory of this project
            string path = "text.txt";

            try
            {
                string readText = File.ReadAllText(path);
                Console.WriteLine("Text:");
                Console.WriteLine(readText);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("This file does not exists.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid file path. You must enter some characters. File path cannot be only white space. The valid symbols are: \\ / . - _ :");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path must be less than 248 characters");
            }
            catch (DirectoryNotFoundException)
            {
                var driveLetter = path.Substring(0, path.IndexOf(':'));
                Console.WriteLine("Invalid path. Drive with letter {0} does not exist", driveLetter);
            }
            catch (IOException)
            {
                Console.WriteLine("File cannot be opened. It might be used by another process.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You don't have rights to read this file.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in an invalid format. ");
            }
            catch (SecurityException)
            {
                Console.WriteLine("You dont have the required permission to access this file.");
            }
        }
    }
}
