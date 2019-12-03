using System;

namespace ClintSharp
{
    public static class GuidExtension
    {
        public static Guid ToGuid(this string value) => Guid.Parse(value);

        public static string NewGuid() => Guid.NewGuid().ToString();
    }
}
