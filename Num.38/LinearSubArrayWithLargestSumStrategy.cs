using System;
using System.Linq;

namespace Num._38
{
    public sealed class LinearSubArrayWithLargestSumStrategy : ISubArrayWithLargestSumStrategy
    {
        public int[] GetSubArrayWithLargestSum(int[] array)
        {
            int start = 0
                , end = 0
                , temp = 0
                , currentSum = 0
                , max = 0;

            var allAreNegative = true;
            var maxValue = array[0];

            for (var i = 0; i < array.Length; i++)
            {
                currentSum += array[i];
                allAreNegative &= (array[i] < 0);
                if (allAreNegative) maxValue = Math.Max(maxValue, array[i]);

                if (currentSum > max)
                {
                    start = temp;
                    end = i;
                    max = currentSum;
                }
                else if (currentSum < 0)
                {
                    currentSum = 0;
                    temp = i + 1;
                }

            }

            if (!allAreNegative)
                return array
                    .Skip(start)
                    .Take(end - start + 1)
                    .ToArray();

            return new[] {maxValue};
        }
    }
}