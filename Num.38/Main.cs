using System;
using System.Diagnostics;
using System.Linq;

namespace Num._38
{
    public static class Main
    {
        /// <summary>
        /// You're given an array containing both positive and negative integers and
        ///required to find the sub-array with the largest sum (O(N) a la KBL)
        /// </summary>
        /// <param name="array">an array containing both positive and negative integers </param>
        /// <returns>the sub-array with the largest sum</returns>
        public static int[] GetSubArrayWithLargestSum(int[] array)
        {
            Trace.TraceInformation("Finding an array with largest sum for: {0}", array.ToArrayString());

            int[] subArrayWithMaxSum;

            int? maxSum = null;

            if (array == null)
            {
                subArrayWithMaxSum = null;
            }
            else if (array.Length == 0)
            {
                subArrayWithMaxSum = new int[0];
            }
            else
            {
                subArrayWithMaxSum = GetSubArrayWithLargestSumInternal(array, out maxSum);
            }

            Trace.TraceInformation("The result is {0} with a max sum of {1}", subArrayWithMaxSum.ToArrayString(), (object) maxSum ?? "(null)");

            return subArrayWithMaxSum;
        }

        private static int[] GetSubArrayWithLargestSumInternal(int[] array, out int? maxSum)
        {
            //var sum = 0;
            //var minSum = 0;
            //var minIndex = -1;
            //var subArrStart = 0; 
            //var subArrEnd = 0;
            //maxSum = 0;

            //for (var i = 0; i < array.Length; i++)
            //{
            //    sum = sum + array[i];

            //    if (sum <= minSum)
            //    {
            //        minSum = sum;
            //        minIndex = i;
            //    }

            //    minSum = Math.Min(sum, minSum);

            //    if (sum - minSum > maxSum)
            //    {
            //        subArrStart = minIndex + 1;
            //        subArrEnd = i + 1;
            //        maxSum = sum - minSum;
            //    }
            //}

            //return array
            //    .Skip(subArrStart)
            //    .Take(subArrEnd)
            //    .ToArray();

            var subArrayWithMaxSum = new[] { array[0] };
            maxSum = array[0];
            var arrayLength = array.Length;

            for (var subArraySize = 1; subArraySize <= arrayLength; subArraySize++)
            {
                for (var subArrayStartIndex = 0; (subArrayStartIndex + subArraySize) <= arrayLength; subArrayStartIndex++)
                {
                    var subArray = array.Skip(subArrayStartIndex)
                        .Take(subArraySize)
                        .ToArray();

                    var sum = subArray.Sum();

                    Trace.TraceInformation("Sub array of {0} has a max sum of {1}", subArray.ToArrayString(), sum);

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        subArrayWithMaxSum = subArray;
                    }
                }
            }
            return subArrayWithMaxSum;
        }

        public static string ToArrayString(this int[] array)
        {
            return array != null ? string.Format("{{{0}}}", string.Join(",", array)) : "{(null)}";
        }
    }
}
