using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClintSharp
{
    public static class CollectionsExtension
    {
        public static string Join(this IEnumerable<string> value, string separator) => string.Join(separator, value);
    }
}
