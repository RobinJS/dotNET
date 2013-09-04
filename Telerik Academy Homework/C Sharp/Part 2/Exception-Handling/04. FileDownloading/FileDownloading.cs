// 4. Write a program that downloads a file from Internet 
//  (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory.
//  Find in Google how to download files in C#. Be sure to catch all exceptions and 
//  to free any used resources in the finally block.

using System;
using System.Net;

namespace _04.FileDownloading
{
    class FileDownloading
    {
        static void Main()
        {
            Console.WriteLine("Enter url address of file to download it:");
            string url = @"" + Console.ReadLine();
            //string url = "http://www.devbg.org/img/Logo-BASD.jpg";
            Console.WriteLine("Enter file name and its extention:");
            string fileName = Console.ReadLine();
            //string fileName = "Logo-BASD.jpg";

            using (WebClient webClient = new WebClient())
            {
                try
                {
                    // You can find the downloaded file in "Debug" directory of this project
                    webClient.DownloadFile(url, fileName);
                }

                catch (WebException)
                {
                    Console.Error.WriteLine("The address is invalid.");
                }

                catch (NotSupportedException)
                {
                    Console.Error.WriteLine("The method has been called simultaneously on multiple threads.");
                }
            }
        }
    }
}
