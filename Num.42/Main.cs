namespace Num._42
{
    public static class Main
    {
        public static bool IsNumberPowerOfTwo(int number)
        {
            return ((number > 0) && (((number - 1) & number) == 0));
        }
    }
}
