using System;

namespace ClintSharp
{
    public static class StringExtension
    {
        public static bool IsNull(this string value) => string.IsNullOrEmpty(value);

        public static bool IsNotNull(this string value) => !string.IsNullOrEmpty(value);

        /// <summary>
        /// Display fallback text for an empty or null string 
        /// </summary>
        /// <param name="fallbackText"></param>
        public static string Fallback(this string value, string fallbackText)
        {
            return string.IsNullOrWhiteSpace(value) ? fallbackText : value;
        }
    }
}
