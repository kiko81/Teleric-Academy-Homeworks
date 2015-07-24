namespace StringExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Static class providing various extension methods to strings
    /// <list type="bullet">
    /// <item> 
    /// <description>ToMd5Hash,</description> 
    /// </item> 
    /// <item> 
    /// <description>ToBoolean,</description> 
    /// </item>
    /// <item> 
    /// <description>ToShort,</description> 
    /// </item> 
    /// <item> 
    /// <description>ToInteger,</description> 
    /// </item>
    /// <item> 
    /// <description>ToLong,</description> 
    /// </item>
    /// <item> 
    /// <description>ToDateTime,</description> 
    /// </item>
    /// <item> 
    /// <description>CapitalizeFirstLetter,</description> 
    /// </item>
    /// <item>
    /// <description>ConvertCyrillicToLatinLetters,</description>
    /// </item>
    /// <item>
    /// <description>ConvertLatinToCyrillicKeyboard,</description>
    /// </item>
    /// <item>
    /// <description>ToValidUsername,</description>
    /// </item>
    /// <item>
    /// <description>ToValidLatinFileName,</description>
    /// </item>
    /// <item>
    /// <description>GetFirstCharacters,</description>
    /// </item>
    /// <item>
    /// <description>GetFileExtension,</description>
    /// </item>
    /// <item>
    /// <description>ToContentType,</description>
    /// </item>
    /// <item>
    /// <description>ToByteArray,</description>
    /// </item>
    /// </list> 
    /// </summary>
    
    public static class StringExtensions
    {
        /// <summary>
        /// converts the target string to a byte array, and computes the hashes for each element.
        /// Elements are formatted as a hexadecimal strings and appended to the resulting
        /// string that is finally returned.
        /// </summary>
        /// <param name="input">
        /// Input string
        /// </param>
        /// <returns>
        /// Returns string of hexadecimal values <see cref="string"/>.
        /// </returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the String input to a byte array and compute the hash.
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
        /// Checks if input is a positive word
        /// </summary>
        /// <param name="input">
        /// String input.
        /// </param>
        /// <returns>
        /// Returns <see cref="bool"/>.
        /// </returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Converts String input to short value
        /// </summary>
        /// <param name="input">
        /// String input.
        /// </param>
        /// <returns>
        /// Returns short value or null if input cannot be parsed <see cref="short"/>.
        /// </returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Converts String input to integer value
        /// </summary>
        /// <param name="input">
        /// String input.
        /// </param>
        /// <returns>
        /// Returns integer value or null if input cannot be parsed <see cref="int"/>.
        /// </returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Converts String input to long value
        /// </summary>
        /// <param name="input">
        /// String input.
        /// </param>
        /// <returns>
        /// Returns long value or null if input cannot be parsed <see cref="long"/>.
        /// </returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Converts String input to DateTime value
        /// </summary>
        /// <param name="input">
        /// String input.
        /// </param>
        /// <returns>
        /// Returns DateTime value or null if input cannot be parsed <see cref="DateTime"/>.
        /// </returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Capitalizes first letter of input
        /// </summary>
        /// <param name="input">
        /// String input.
        /// </param>
        /// <returns>
        /// Returns the input with capitalized first letter <see cref="string"/>.
        /// </returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Gets substring between two other substrings.
        /// </summary>
        /// <param name="input">
        /// Input string
        /// </param>
        /// <param name="startString">
        /// Input start string.
        /// </param>
        /// <param name="endString">
        /// Input end string.
        /// </param>
        /// <param name="startFrom">
        /// Input index to start search from.
        /// </param>
        /// <returns>
        /// Returns the founded substring or empty one <see cref="string"/>.
        /// </returns>
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
        /// Converts Cyrillic letters to Latin letters
        /// </summary>
        /// <param name="input">
        /// Input string.
        /// </param>
        /// <returns>
        /// Returns string with Latin letters only <see cref="string"/>.
        /// </returns>
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
        /// Converts Latin letters to Cyrillic letters
        /// </summary>
        /// <param name="input">
        /// Input string.
        /// </param>
        /// <returns>
        /// Returns string with Cyrillic letters only <see cref="string"/>.
        /// </returns>
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
        /// Converts Cyrillic letters to Latin letters
        /// </summary>
        /// <param name="input">
        /// Input string.
        /// </param>
        /// <returns>
        /// Returns valid username string with Latin letters only <see cref="string"/>.
        /// </returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Converts Cyrillic chars of filename to Latin for returning valid filename
        /// </summary>
        /// <param name="input">
        /// String input. 
        /// </param>
        /// <returns>
        /// Returns valid file name<see cref="string"/>.
        /// </returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Gets first X characters.
        /// </summary>
        /// <param name="input">
        /// String input.
        /// </param>
        /// <param name="charsCount">
        /// Number of chars to get - if greater than length - gets whole word
        /// </param>
        /// <returns>
        /// <see cref="string"/>.
        /// </returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Gets file extension.
        /// </summary>
        /// <param name="fileName">
        /// File name - string
        /// </param>
        /// <returns>
        /// File extension after the last dot <see cref="string"/>.
        /// </returns>
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
        /// Gets content type of file
        /// </summary>
        /// <param name="fileExtension">
        /// String file extension.
        /// </param>
        /// <returns>
        /// Returns content type of file according to its extension <see cref="string"/>.
        /// </returns>
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
        /// Converts given string to array of bytes
        /// </summary>
        /// <param name="input">
        /// The input.
        /// </param>
        /// <returns>
        /// An array of bytes from converting every character 
        /// in the given string to its byte representation<see cref="byte[]"/>.
        /// </returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
