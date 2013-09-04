// 10. Write a program that extracts from given XML file all the text without the tags.

using System;
using System.IO;

namespace _10.TextFromXML
{
    class TextFromXML
    {
        public static string filePath = @"../../info.xml";
        public static string xmlContent = "";

        static void Main()
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                xmlContent = reader.ReadToEnd();
            }

            int startIndex = 0;
            int endIndex = 0;
            for (int i = 0; i < xmlContent.Length; i++)
            {
                if (xmlContent[i] == '>')
                {
                    startIndex = i + 1;
                }
                if (xmlContent[i] == '<' && i > startIndex)
                {
                    endIndex = i;
                    GetCurrentText(startIndex, endIndex);
                }

            }
        }

        private static void GetCurrentText(int startIndex, int endIndex)
        {
            int substringLength = endIndex - startIndex;
            string currentText = xmlContent.Substring(startIndex, substringLength);
            Console.WriteLine(currentText);
        }
    }
}
