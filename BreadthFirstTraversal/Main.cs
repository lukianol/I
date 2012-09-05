using System;
using System.Collections.Generic;
using System.IO;
using Common;

namespace BreadthFirstTraversal
{
    public static class Main
    {
        public static void TraverseBinaryTreeBreadthFirst<T>(BinaryTree<T> tree, TextWriter writer)
        {
            if (tree == null) 
                throw new ArgumentNullException("tree");
            if (writer == null) 
                throw new ArgumentNullException("writer");

            PrintLevel(writer, tree.Root);
        }

        private static void PrintLevel<T>(TextWriter writer, params BinaryTreeNode<T>[] nodes)
        {
            var list = new List<BinaryTreeNode<T>>(nodes.Length * 2);
            foreach (var node in nodes)
            {
                writer.Write(node.Value);
                AddNode(list, node.Left);
                AddNode(list, node.Right);
            }
            
            if (list.Count > 0)
                PrintLevel(writer, list.ToArray());
        }

        private static void AddNode<T>(ICollection<BinaryTreeNode<T>> list, BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                list.Add(node);
            }
        }
    }
}
