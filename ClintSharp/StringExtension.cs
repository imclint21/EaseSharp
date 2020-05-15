using System;
using System.Collections.Generic;

namespace ClintSharp
{
    public static class StringExtension
    {
        /// <summary>
        /// Detect if an object is null
        /// </summary>
        public static bool IsNull(this string value) => string.IsNullOrEmpty(value);

        /// <summary>
        /// Detect if an object is not null
        /// </summary>
        public static bool IsNotNull(this string value) => !string.IsNullOrEmpty(value);
        
        /// <summary>
        /// Detect if a string is an empty string
        /// </summary>
        public static bool IsEmpty(this string value) => value.Trim().Equals(string.Empty);

        public static bool IsDefault<T>(this object value) => Equals(value, default(T));

        /// <summary>
        /// Display fallback text for an empty or null string 
        /// </summary>
        public static string Fallback(this string value, string fallbackText)
        {
            return string.IsNullOrWhiteSpace(value) ? fallbackText : value;
        }
    }
}
