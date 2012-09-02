using System;
using System.Collections.Generic;

namespace Num._46
{
    public static class Main
    {
        public static void InsertInSortedList<T>(List<T> list, T item) where T : IComparable  
        {
            if (list == null) throw new ArgumentNullException("list");

            list.Sort();//just in case it was not sorted
            var index = BinarySearch(list, item);
            if (index < 0)
            {
                list.Insert(~index, item);
            }
        }


        /// <summary>
        /// It mades this algorithm more self-made then when out of the box method is used
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        private static int BinarySearch<T>(IList<T> list, T item) where T : IComparable 
        {
            int num1 = 0;
            int num2 = 0 + list.Count - 1;
            while (num1 <= num2)
            {
                int index1 = num1 + (num2 - num1 >> 1);
                int num3 = (object) list[index1] != null
                               ? list[index1].CompareTo(item)
                               : ((object) item == null ? 0 : -1);
                if (num3 == 0)
                    return index1;
                if (num3 < 0)
                    num1 = index1 + 1;
                else
                    num2 = index1 - 1;
            }
      return ~num1;
    }
        
    }
}
