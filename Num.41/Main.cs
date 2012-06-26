using System;
using System.IO;

namespace Num._41
{
    public static class Main
    {
        public static void PrintOutUlongCharByChar(ulong value, TextWriter writer)
        {
            ulong reversed = 0;

            while (value != 0)
            {
                var number = value%10;
                reversed = reversed*10 + number;
                value = (ulong) Math.Floor((decimal) value/10);
            }

            while (reversed != 0)
            {
                var number = reversed % 10;
                writer.Write(number);
                reversed = (ulong)Math.Floor((decimal)reversed / 10);    
            }
            
        }

 
    }
}
