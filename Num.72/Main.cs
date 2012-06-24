namespace Num._72
{
    public static class Main
    {
        public static uint SetHighestSignificantBitToZero(uint value)
        {
            var position = 0;
            var tmp = value;

            while ((tmp | 0x01) != 0x01)
            {   
               tmp = tmp >> 1;
               position++;
            }

            return (uint)(value & (~(0x01 << position)));
        }
    }
}
