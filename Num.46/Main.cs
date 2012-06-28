using System.Collections.Generic;

namespace Num._46
{
    public static class Main
    {
        public static void InsertInSortedList<T>(List<T> list, T item)
        {
            list.Sort();//just in case it was not sorted
            var index = list.BinarySearch(item);
            if (index < 0)
            {
                list.Insert(~index, item);
            }
        }
    }
}
