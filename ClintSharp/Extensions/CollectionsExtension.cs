using System.Collections.Generic;

namespace ClintSharp
{
    public static class CollectionsExtension
    {
        public static string Join(this IEnumerable<string> value, string separator) => string.Join(separator, value);
    }
}
