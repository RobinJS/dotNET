/* 12. Write a program that parses an URL address given in the format:
 *      [protocol]://[server]/[resource]
 * and extracts from it the [protocol], [server] and [resource] elements.
 * For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
 *      [protocol] = "http"
 *      [server] = "www.devbg.org"
 *      [resource] = "/forum/index.php"
 */

using System;

namespace _12.URLParse
{
    class URLParse
    {
        static void Main()
        {
            Console.WriteLine("Enter URL:");
            string url = Console.ReadLine();
            //string url = "http://www.devbg.org/forum/index.php";

            string protocol = url.Substring(0, url.IndexOf(':'));
            int end = 0;

            for (int i = 0; i < url.Length; i++)
            {
                if (url[i] == '.')
                {
                    end = i;
                }

                if (url[i] == '/' && end != 0)
                {
                    end = i;
                    break;
                }
            }

            int length = end - url.IndexOf('w');
            string server = url.Substring(url.IndexOf('w'), length);
            string resource = url.Substring(end, url.Length - end);

            Console.WriteLine("[protocol] = \"{0}\"", protocol);
            Console.WriteLine("[server] = \"{0}\"", server);
            Console.WriteLine("[resource] = \"{0}\"", resource);
        }
    }
}
