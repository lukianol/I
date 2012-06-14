namespace Num._38
{
    public static class Main
    {
        /// <summary>
        /// You're given an array containing both positive and negative integers and
        ///required to find the sub-array with the largest sum (O(N) a la KBL)
        /// </summary>
        /// <param name="array">an array containing both positive and negative integers </param>
        ///<param name="strategy">The actual algorithm, I've implemented two of them, one for test and another as an answer</param>
        ///<returns>the sub-array with the largest sum</returns>
        public static int[] GetSubArrayWithLargestSum(int[] array, ISubArrayWithLargestSumStrategy strategy)
        {
            int[] subArrayWithMaxSum;
            
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
                subArrayWithMaxSum = strategy.GetSubArrayWithLargestSum(array);
            }

            return subArrayWithMaxSum;
        }

        public static string ToArrayString(this int[] array)
        {
            return array != null ? string.Format("{{{0}}}", string.Join(",", array)) : "{(null)}";
        }
    }
}
