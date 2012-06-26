using System;
using System.IO;
using Common;

namespace Num._68
{
    /// <summary>
    /// <see cref="http://msdn.microsoft.com/en-us/library/ms379572(v=vs.80).aspx"/>
    /// </summary>
    public static class Main
    {
        public static void PreorderTraversal<T>(BinaryTree<T> tree, TextWriter writer)
        {
            if (tree == null) 
                throw new ArgumentNullException("tree");

            PreorderTraversalInternal(tree.Root, writer);
        }

        public static void InorderTraversal<T>(BinaryTree<T> tree, TextWriter writer)
        {
            if (tree == null)
                throw new ArgumentNullException("tree");

            InorderTraversalInternal(tree.Root, writer);
        }

        public static void PostorderTraversal<T>(BinaryTree<T> tree, TextWriter writer)
        {
            if (tree == null)
                throw new ArgumentNullException("tree");

            PostorderTraversalInternal(tree.Root, writer);
        }

        private static void PostorderTraversalInternal<T>(BinaryTreeNode<T> current, TextWriter writer)
        {
            if (current == null) return;
            PostorderTraversalInternal(current.Left, writer);
            PostorderTraversalInternal(current.Right, writer);
            writer.Write(current.Value);


        }

        private static void InorderTraversalInternal<T>(BinaryTreeNode<T> current, TextWriter writer)
        {
            if (current == null) return;
            InorderTraversalInternal(current.Left, writer);
            writer.Write(current.Value);
            InorderTraversalInternal(current.Right, writer);
        }

        private static void PreorderTraversalInternal<T>(BinaryTreeNode<T> current, TextWriter writer)
        {
            if (current == null) return;
            writer.Write(current.Value);
            PreorderTraversalInternal(current.Left, writer);
            PreorderTraversalInternal(current.Right, writer);
        }
    }
}
