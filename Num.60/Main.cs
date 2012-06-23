using System.Collections.Generic;

namespace Num._60
{
    public static class Main
    {  
        public static int[] CompressArray(int[] array)
        {
            var hashes = new HashSet<int>(array);
            var compressedArray = new int[hashes.Count];
            hashes.CopyTo(compressedArray, 0);
            return compressedArray;
        }
    }
}
