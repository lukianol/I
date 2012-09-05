using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class BinaryHeap<T> where T : IComparable
    {
        public void Add(T item)
        {
            _storage.Add(item);

            var bubbleIndex = _storage.Count - 1;

            while (bubbleIndex != 0)
            {
                var parentIndex = (bubbleIndex - 1) / 2;

                if (_storage[bubbleIndex].CompareTo(_storage[parentIndex]) > 0)
                {
                    break;
                }

                var tmpValue = _storage[parentIndex];
                _storage[parentIndex] = _storage[bubbleIndex];
                _storage[bubbleIndex] = tmpValue;
                bubbleIndex = parentIndex;
            }
        }

        private readonly List<T> _storage = new List<T>();
    }
}
