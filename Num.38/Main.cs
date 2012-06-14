namespace Num._38
{
    public static class Main
    {
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
