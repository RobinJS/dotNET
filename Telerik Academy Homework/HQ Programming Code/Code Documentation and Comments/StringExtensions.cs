﻿namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// 
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// This method gets MD5 hash from a string.
        /// </summary>
        /// <param name="input">String for input.</param>
        /// <returns>Returns hexadecimal string.</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// This method chechs for a scpecific input keyword.
        /// </summary>
        /// <param name="input">Takes string to be checked.</param>
        /// <returns>The method returns boolean value.</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// This method parses to Int16 integer number.
        /// </summary>
        /// <param name="input">The method takes string as input.</param>
        /// <returns>Returns short value if the parse is successful.</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// This method parses to Int32 integer number.
        /// </summary>
        /// <param name="input">The method takes string as input.</param>
        /// <returns>Returns int value if the parse is successful.</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// This method parses to Int64 integer number.
        /// </summary>
        /// <param name="input">The method takes string as input.</param>
        /// <returns>Returns long value if the parse is successful.</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// This method converts a string into a date-time value.
        /// </summary>
        /// <param name="input">Takes string as input.</param>
        /// <returns>Returns date-tiem value if the parse is successfull.</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// This method capitalizes the first letter of a string.
        /// </summary>
        /// <param name="input">Takes string as input.</param>
        /// <returns>Returns null or empty string if the input is null or empty string. Otherwise returns the same string with capital first letter.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// This method takes a substring from a string.
        /// </summary>
        /// <param name="input">Input is the string we wat to take a substring from.</param>
        /// <param name="startString">startString points the substring beginning.</param>
        /// <param name="endString">endString points the substring end.</param>
        /// <param name="startFrom">startFrom is an integer number that shows the beginning of the substring</param>
        /// <returns>If input contains no startString nor endString, the method returns empty string.</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// This method converts Cyrillic letters to ToLatin letters.
        /// </summary>
        /// <param name="input">The input is a string.</param>
        /// <returns>Returns the input converted.</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                {
                    "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                    "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                };
            var latinRepresentationsOfBulgarianLetters = new[]
                {
                    "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                    "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                    "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// This method converts ToLatin letters to Cyrillic letters.
        /// </summary>
        /// <param name="input">Takes a string as input.</param>
        /// <returns>Returns the input converted.</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                {
                    "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                    "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                {
                    "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                    "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                    "в", "ь", "ъ", "з"
                };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Converts a not valid username to valid username by replacing characters.
        /// </summary>
        /// <param name="input">Invakud username as a string.</param>
        /// <returns>Returns valid username.</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Converts a not valid file name to valid filename.
        /// </summary>
        /// <param name="input">File name as a string.</param>
        /// <returns>Valid filename.</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Takes a specified number of the first characters of a string.
        /// </summary>
        /// <param name="input">The string we take characters from.</param>
        /// <param name="charsCount">Integer number assigning how many characters to be taken.</param>
        /// <returns>Returns taken charascters.</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// This method returns the file extention from a file name by splitting it's name.
        /// </summary>
        /// <param name="fileName">Full file name as a string.</param>
        /// <returns>If fileName is null, empty or the string cannot be splitted, returns empty string. Otherwise returns the file extention.</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// This method gets the content type of file extention.
        /// </summary>
        /// <param name="fileExtension">File extention as a string.</param>
        /// <returns>Returns the content type of the file extention. If it is not found, returns a default string.</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                {
                    { "jpg", "image/jpeg" },
                    { "jpeg", "image/jpeg" },
                    { "png", "image/x-png" },
                    {
                        "docx",
                        "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                    },
                    { "doc", "application/msword" },
                    { "pdf", "application/pdf" },
                    { "txt", "text/plain" },
                    { "rtf", "application/rtf" }
                };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts a string to byte array.
        /// </summary>
        /// <param name="input">String to be converted.</param>
        /// <returns>Returns array of characters.</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }

        static void Main()
        {
            
        }
    }
}
