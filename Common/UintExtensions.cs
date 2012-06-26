using System;
using Common;

namespace Common
{
    public static class UintExtensions
    {
        public static string ToBinaryString(this uint value)
        {
            var actual = Convert.ToString(value, 2);
            return actual.PadLeft(TotalWidth, '0');
        }

        private const int TotalWidth = sizeof(uint) * 8;

    }
}




    

    
