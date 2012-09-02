namespace Num._44
{
    public static class Main
    {
        public static int GetNumberOfOnes(int number)
        {
            const int sizeinBits = sizeof (int) * 8;
            var counter = 0;

            for (var i = 0; i < sizeinBits; i++)
            {
                if (number == 0) break;
                counter += (number & 0x1);
                number >>= 1;
            }

            return counter;
        }

        /// <summary>
        /// This algorithm is really a hard rock. And hard to epxlain.
        /// I got it from http://stackoverflow.com/questions/109023/best-algorithm-to-count-the-number-of-set-bits-in-a-32-bit-integer
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int GetNumberOfOnesV2(int i)
        {
            i = i - ((i >> 1) & 0x55555555);
            i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
            return (((i + (i >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24;
        }

        public static int GetNumberOfOnesV3(int number)
        {
            int i;

            for (i = 0; number != 0; i++)
                number &= number - 1;

            return i;
        }    

    }
}
