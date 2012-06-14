using System.Linq;

namespace Num._38
{
    public sealed class CalibratingSubArrayWithLargestSumStrategy : ISubArrayWithLargestSumStrategy
    {
        public int[] GetSubArrayWithLargestSum(int[] array)
        {
            var subArrayWithMaxSum = new[] { array[0] };
            var arrayLength = array.Length;
            int maxSum = array[0];

            for (var subArraySize = 1; subArraySize <= arrayLength; subArraySize++)
            {
                for (var subArrayStartIndex = 0; (subArrayStartIndex + subArraySize) <= arrayLength; subArrayStartIndex++)
                {
                    var subArray = array.Skip(subArrayStartIndex)
                        .Take(subArraySize)
                        .ToArray();

                    var sum = subArray.Sum();

                    if (sum > maxSum)
                    {
                        subArrayWithMaxSum = subArray;
                        maxSum = sum;
                    }
                }
            }

            return subArrayWithMaxSum;
        }
    }
}