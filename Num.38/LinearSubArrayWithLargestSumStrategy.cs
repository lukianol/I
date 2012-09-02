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
                , newStart = 0
                , currentSum = 0
                , capturedSum = 0;

            var allAreNegative = true;
            var maxValueInCaseOfAllNegatives = array[0];

            for (var i = 0; i < array.Length; i++)
            {
                currentSum += array[i];
                allAreNegative &= (array[i] < 0);
                if (allAreNegative) maxValueInCaseOfAllNegatives = Math.Max(maxValueInCaseOfAllNegatives, array[i]);

                if (currentSum > capturedSum)
                {
                    start = newStart;
                    end = i;
                    capturedSum = currentSum;
                }
                else if (currentSum < 0)
                {
                    currentSum = 0;
                    newStart = i + 1;
                }

            }

            if (!allAreNegative)
                return array
                    .Skip(start)
                    .Take(end - start + 1)
                    .ToArray();

            return new[] {maxValueInCaseOfAllNegatives};
        }
    }
}