using System.Collections.Generic;

namespace Num._60
{
    public static class Main
    {  
        public static T[] CompressArray<T>(T[] array)
        {
            var hashes = new HashSet<T>(array);
            var compressedArray = new T[hashes.Count];
            hashes.CopyTo(compressedArray, 0);
            return compressedArray;
        }
    }
}
