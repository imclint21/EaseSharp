using System;
using System.Linq;

namespace ClintSharp
{
    public static class DateTimeExtension
    {
        /// <summary>
        /// Convert a DateTime to Timestamp
        /// </summary>
        public static long ToTimestamp(this DateTime value) => (long)value.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

        /// <summary>
        /// Get the nearest date from a DateTime array
        /// </summary>
        public static DateTime GetNearestDate(DateTime dateTime, params DateTime[] dateTimes) => dateTimes.OrderBy(t => Math.Abs((t - dateTime).Ticks)).First();
    }
}
