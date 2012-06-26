using System;
using Common;

namespace Num._51
{
    public static class Main
    {
        public static int DepthOfBinaryTree<T>(BinaryTree<T> tree)
        {
            if (tree == null) 
                throw new ArgumentNullException("tree");

            return DepthInternal(tree.Root);
        }

        private static  int DepthInternal<T>(BinaryTreeNode<T> treeNode)
        {
            if (treeNode == null) return 0;
            var depthLeft = DepthInternal(treeNode.Left);
            var depthRight = DepthInternal(treeNode.Right);
            return Math.Max(depthLeft, depthRight) + 1;

        }
    }
}
