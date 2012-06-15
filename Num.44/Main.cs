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
    }
}
