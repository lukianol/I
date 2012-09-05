using System;

namespace Num._63
{
    public static class Main
    {
        /*There is a better solution */
        public static void LargestAndSmallestLexStringFromArray(string[] array, out string smallest, out string largest)
        {
            if (array == null)
                throw new ArgumentNullException("array");

            if (array.Length == 0)
            {
                largest = smallest = null;
                return;                    
            }

            largest = smallest = array[0];

            foreach (var value in array)
            {
                if (String.Compare(value, largest, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    largest = value;
                }

                if (String.Compare(value, smallest, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    smallest = value;
                }
            }
        }
    }
}