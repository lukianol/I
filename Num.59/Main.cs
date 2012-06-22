using System;

namespace Num._59
{
    public static class Main
    {
        public static void Sort(int[] array, int k)
        {
            var tmp = new int[k];

            for (int i = 0; i < array.Length; i++)
            {
                var value = array[i];

                if ((value < 1) || (value > k))
                    throw new ArgumentException("The array may contain integers between 1 and K", "array");

                tmp[value - 1]++;
            }

            int position = 0;

            for (int i = 0; i < k; i++)
            {
                if (tmp[i] == 0)
                    continue;

                array[position++] = i + 1;
            }
        }
    }
}