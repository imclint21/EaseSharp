using System.Linq;

namespace ClintSharp
{
    public static class MathExtension
    {
        /// <summary>
        /// Get the average of a int array
        /// </summary>
        public static double Average(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }
            return numbers.ToList().Sum() / numbers.Length;
        }
    }
}
