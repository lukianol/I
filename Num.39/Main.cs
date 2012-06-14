using System;

namespace Num._39
{
    public static class Main
    {
        public static bool HasArrayDuplicates(int[] array)
        {
            if (array == null) 
                throw new ArgumentNullException("array");

            var n = array.Length;
            var markers = new int[n];

            for (var i = 0; i < n; i++)
            {
                var value = array[i];
                if ((value < 1) || (value > n))
                    throw new ArgumentOutOfRangeException("array", "Values of the array must be between 1 and N, where N is an array length");

                var markerIndex = value - 1;

                if (markers[markerIndex] == 0)
                    markers[markerIndex]++;
                else
                    return true;
            }

            return false;
        }
    }
}
