using System;

namespace ClintSharp
{
    public static class GuidExtension
    {
        /// <summary>
        /// Convert a string to a Guid
        /// </summary>
        public static Guid ToGuid(this string value) => Guid.Parse(value);
    }
}
