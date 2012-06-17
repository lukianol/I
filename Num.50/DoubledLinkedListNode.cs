namespace Num._50
{
    public sealed class DoubledLinkedListNode<T>
    {

        public DoubledLinkedListNode()
        {
            Next = Previous = Terminator;
        }

        public DoubledLinkedListNode(T value) : this()
        {
            Value = value;
        }

        public DoubledLinkedListNode<T> Previous { get; set; }
        public DoubledLinkedListNode<T> Next { get; set; }
        public T Value { get; set; }

        public static DoubledLinkedListNode<T> Terminator = new DoubledLinkedListNode<T>();
    }
}