using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Common
{
   public sealed class LinkedList<T> : IEnumerable<T>
   {
       public void Add(T value)
       {
          Add(_count, value);
       }

       public void Add(int index, T value)
       {
           if (index < 0)
               throw new ArgumentException();

           var node = new Node { Value = value };

           if (index == 0)
           {
               node.Next = _head;
               _head = node;
           }
           else
           {
               var current = _head;

               for (var i = 1; i < index; i++)
               {
                   if (current == null)
                       throw new IndexOutOfRangeException();
                   current = current.Next;
               }

               var tmp = current.Next;
               current.Next = node;
               node.Next = tmp;
           }
           _count++;
       }

       public void Delete(int index)
       {
           if (index < 0)
               throw new ArgumentException();

           if (index == 0)
           {
               if (_head == null)
                   throw new IndexOutOfRangeException();

               _head = _head.Next;
           }
           else
           {
               var current = _head;

               for (var i = 1; i < index; i++)
               {
                   if (current == null)
                       throw new IndexOutOfRangeException();
                   current = current.Next;
               }

               if (current == null)
                   throw new IndexOutOfRangeException();
               var tmp = current.Next;
               current.Next = tmp != null ? tmp.Next : null;

           }

           _count--;
          
       }

       public T Get(int index)
       {
           if (index < 0)
               throw new ArgumentException();

           var current = _head;

           for(var i = 1; i <= index; i++)
           {
               if (current == null)
                   throw new IndexOutOfRangeException();

               current = current.Next;
           }

           if (current == null)
               throw new IndexOutOfRangeException();

           return current.Value;
       }

       private Node _head;
       private int _count;

       private sealed class Node
       {
           public T Value;
           public Node Next;
       }

       public IEnumerator<T> GetEnumerator()
       {
           return new Enumerator(this);
       }

       IEnumerator IEnumerable.GetEnumerator()
       {
           return GetEnumerator();
       }

       private class Enumerator : IEnumerator<T>
       {
           private readonly LinkedList<T> _list;
           private int _index;

           public Enumerator(LinkedList<T> list)
           {
               _list = list;
               Reset();
           }

           public void Dispose()
           {
           }

           public bool MoveNext()
           {
               _index++;
               try
               {
                   Current = _list.Get(_index);
                   return true;
               }
               catch (IndexOutOfRangeException)
               {
                   return false;
               }
           }

           public void Reset()
           {
               _index = -1;
               Current = default(T);
           }

           public T Current { get; private set; }

           object IEnumerator.Current
           {
               get { return Current; }
           }
       }
   }
}
