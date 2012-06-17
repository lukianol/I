using System.Collections;
using System.Collections.Generic;

namespace Num._50
{
    public class DoubledLinkedList<T> : IEnumerable<T>
    {
        private static readonly DoubledLinkedListNode<T> Terminator = DoubledLinkedListNode<T>.Terminator;

        public DoubledLinkedList()
        {
            First = Last = Terminator;
        }

        public DoubledLinkedList(IEnumerable<T> values) : this()
        {
            foreach (T value in values)
            {
                Add(value);
            }
        }

        public DoubledLinkedListNode<T> First { get; private set; }
        public DoubledLinkedListNode<T> Last { get; private set; }

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        /// <summary>
        /// Deletes all nodes with such <paramref name="value"/>
        /// </summary>
        /// <param name="value">Value to delete from the list</param>
        public void Delete(T value)
        {
            if (First == Terminator)
                return;
            
            var candidateToDelete = First;

            do
            {
                var next = candidateToDelete.Next;

                if (Equals(candidateToDelete.Value, value))
                {
                    var previous = candidateToDelete.Previous;

                    if (previous != Terminator)
                    {
                        previous.Next = next;
                    }
                    else
                    {
                        First = next;
                        next.Previous = Terminator;
                    }

                    if (next != Terminator)
                    {
                        next.Previous = previous;
                    }
                    else
                    {
                        Last = previous;
                        previous.Next = Terminator;
                    }
                }
                candidateToDelete = next;
            } 
            while (candidateToDelete != Terminator);
        }

        public void Add(T value)
        {
            var newNode = new DoubledLinkedListNode<T>(value);

            if (Last == Terminator)
            {
                First = Last = newNode;
            }
            else
            {
                Last.Next = newNode;
                newNode.Previous = Last;
                Last = newNode;
            }
        }

        #region Nested type: Enumerator

        private sealed class Enumerator : IEnumerator<T>
        {
            private readonly DoubledLinkedList<T> _list;
            private DoubledLinkedListNode<T> _currentNode;

            public Enumerator(DoubledLinkedList<T> list)
            {
                _list = list;
                Reset();
            }

            #region IEnumerator<T> Members

            public void Dispose()
            {
                _currentNode = null;
            }

            public bool MoveNext()
            {
                _currentNode = _currentNode == Terminator ? _list.First : _currentNode.Next;

                return (_currentNode != Terminator);
            }

            public void Reset()
            {
                _currentNode = Terminator;
            }

            public T Current
            {
                get { return _currentNode.Value; }
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

            #endregion
        }

        #endregion
    }
}