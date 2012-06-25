using System;

namespace Num._71
{
    public static class Main
    {
        public static uint DiscreteLog2(uint value)
        {
            if (value == 0)
                throw new ArgumentException("Result is -Infinity for '0'", "value");
           
            uint position = sizeof(uint) * 8 - 1;
            const uint mask = 0x80000000;

            while ((value & mask) != mask)
            {
                value = value << 1;
                position--;
            }

            return position;
        }
    }
}
