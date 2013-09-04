// Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Substring_Extension
{
    public static class Extentions
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            return new StringBuilder(str.ToString().Substring(index, length));
        }
    }

    class ExtensionDemo
    {
        static void Main()
        {
            string str = "Implement an extension method";
            int index = 13;
            int length = 9;
            StringBuilder sb = new StringBuilder(str.Substring(index, length));

            Console.WriteLine(sb);
        }
    }
}
