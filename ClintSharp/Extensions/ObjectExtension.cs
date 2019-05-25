using System;

namespace ClintSharp
{
    public static class ObjectExtension
    {
        public static bool IsNull(this object value) => value == null;
    }
}
