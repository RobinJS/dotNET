/* 15. Write a program that replaces in a HTML document given as string 
 * all the tags <a href="…">…</a> with corresponding tags [URL=…]…[/URL].
 *  Sample HTML fragment:
 *      <p>Please visit <a href="http://academy.telerik.com">our site</a> to choose
 *      a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss
 *      the courses.</p>
 *  Result:
 *      <p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a 
 *      training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
 */

using System;

namespace _15.TagsReplacement
{
    class TagsReplacement
    {
        static void Main()
        {
            Console.WriteLine("Enter html text:");
            //string html = Console.ReadLine();
            string html = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            string newHTML = html;
            newHTML = newHTML.Replace("<a href=\"", "[URL=");
            newHTML = newHTML.Replace("\">", "]");
            newHTML = newHTML.Replace("</a>", "[/URL]");

            Console.WriteLine(newHTML);
        }
    }
}
