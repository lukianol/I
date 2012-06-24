using System;

namespace Num._70
{
    public static class Main
    {
        public static uint ReverseTheBits(uint value)
        {
            value = value >> 16 | (0x0000FFFF & value) << 16;
            value = (0xFF00FF00 & value) >> 8 | (0x00FF00FF & value) << 8;
            value = (0xF0F0F0F0 & value) >> 4 | (0x0F0F0F0F & value) << 4;
            value = (0xCCCCCCCC & value) >> 2 | (0x33333333 & value) << 2;
            value = (0xAAAAAAAA & value) >> 1 | (0x55555555 & value) << 1;
            return value;
        }
    }
}
