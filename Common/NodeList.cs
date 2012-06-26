using System.Collections.ObjectModel;
using System.Linq;

namespace Common
{
    public class NodeList<T> : Collection<Node<T>>
    {
        public NodeList()
        { }

        public NodeList(int initialSize)
        {
            for (var i = 0; i < initialSize; i++)
                Items.Add(default(Node<T>));
        }

        public Node<T> FindByValue(T value)
        {
            return Items.FirstOrDefault(node => node.Value.Equals(value));
        }
    }
}