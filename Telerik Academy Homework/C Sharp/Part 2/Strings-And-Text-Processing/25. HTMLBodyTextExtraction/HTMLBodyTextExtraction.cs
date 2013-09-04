/*25. Write a program that extracts from given HTML file its title (if available), 
 * and its body text without the HTML tags.
 * Example:
 *      <html>
 *          <head><title>News</title></head><body><p><a href="http://academy.telerik.com">Telerik
 *          Academy</a>aims to provide free real-world practical
 *          training for young people who want to turn into
 *          skillful .NET software engineers.</p></body>
 *      </html>
 */

using System;
using System.IO;

namespace _25.HTMLBodyTextExtraction
{
    class HTMLBodyTextExtraction
    {
        static void Main()
        {
            string filePath = @"../../index.html";
            string html = "";
            string title = "";
            string HTMLText = "";

            using (StreamReader reader = new StreamReader(filePath))
            {
                html = reader.ReadToEnd();
            }

            /* Getting the title if any */
            int startIndex = html.IndexOf("<title>");
            int endIndex = 0;

            if (startIndex != -1)
            {
                endIndex = html.IndexOf("</title>");
                title = html.Substring(startIndex + 7, endIndex - (startIndex + 7));
            }

            /* Getting the html text */
            startIndex = html.IndexOf("<body>") + 6;
            endIndex = html.IndexOf("</body>");

            HTMLText = html.Substring(startIndex, endIndex - startIndex);

            /* Clearing the body content */
            while (true)
            {
                startIndex = HTMLText.IndexOf("<");
                if (startIndex == -1)
                {
                    break;
                }

                endIndex = HTMLText.IndexOf(">") + 1;
                string tag = HTMLText.Substring(startIndex, endIndex - startIndex);
                HTMLText = HTMLText.Replace(tag, " ").Trim();
            }

            HTMLText = HTMLText.Replace("\r\n", "");

            /* Printing result */
            if (title != "")
            {
                Console.WriteLine("HTML title: {0}", title);
            }

            Console.WriteLine("HTML body text: {0}", HTMLText);
        }
    }
}
