using System;
using Common;

namespace Num._48
{
    public static class Main
    {
        public static void AddToLinkedList<T>(LinkedList<T> list, T value)
        {
            if (list == null)
                throw new ArgumentNullException("list");

            list.Add(value);
        }

        public static void AddToLinkedList<T>(LinkedList<T> list, T value, int index)
        {
            if (list == null)
                throw new ArgumentNullException("list");

            list.Add(index, value);
        }

        public static void DeleteFromLinkedList<T>(LinkedList<T> list, int index)
        {
            if (list == null)
                throw new ArgumentNullException("list");

            list.Delete(index);
        }

        public static T GetFromLinkedList<T>(LinkedList<T> list, int index)
        {
            if (list == null)
                throw new ArgumentNullException("list");

            return list.Get(index);
        }
    }
}
