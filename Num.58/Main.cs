using System;
using System.Collections.Generic;

namespace Num._58
{
    public static class Main
    {
        public static ICollection<int> GetUniqueElements(ICollection<int> sortedCollection)
        {
            if (sortedCollection == null) 
                throw new ArgumentNullException("sortedCollection");

            var resultedList = new HashSet<int>();

            int? previous = null;

            foreach (var element in sortedCollection)
            {
                if (element == previous) 
                    continue;

                if (!resultedList.Add(element))
                    throw new ArgumentException("The list may not be sorted", "sortedCollection");

                previous = element;
            }

            return resultedList;
        }
    }
}
