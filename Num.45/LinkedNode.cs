namespace Num._45
{
    public sealed class LinkedNode<T>
    {
        public LinkedNode()
        {
            
        }

        public LinkedNode(T value)
        {
            Value = value;
        }

        public T Value;
        public LinkedNode<T> Next = TerminatedNode;

        public readonly static LinkedNode<T> TerminatedNode = new LinkedNode<T>(); 
    }
}