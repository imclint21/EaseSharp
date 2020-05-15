using System;

namespace ClintSharp
{
    public static class ObjectExtension
    {
        /// <summary>
        /// Detect if an object is null
        /// </summary>
        public static bool IsNull(this object value) => value == null;

        /// <summary>
        /// Detect if an object is not null
        /// </summary>
        public static bool IsNotNull(this object value) => value != null;
        
        /// <summary>
        /// Detect if an object has the default value
        /// </summary>
        public static bool IsDefault<T>(this object value) => Equals(value, default(T));
    }
}
