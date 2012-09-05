using System.IO;
using Common;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class BreadthFirstTraversal_Test
    {
        [Test]
        public void Test()
        {
            var binaryTree = new BinaryTree<string>
                                 {
                                     Root = new BinaryTreeNode<string>("A")
                                                {
                                                    Left = new BinaryTreeNode<string>("B")
                                                               {
                                                                   Left = new BinaryTreeNode<string>("D")
                                                               },
                                                    Right = new BinaryTreeNode<string>("C")
                                                                {
                                                                    Right = new BinaryTreeNode<string>("E")
                                                                }
                                                }
                                 };

            using (var writer = new StringWriter())
            {
                BreadthFirstTraversal.Main.TraverseBinaryTreeBreadthFirst(binaryTree, writer);
                Assert.AreEqual("ABCDE", writer.ToString());
            }
            
        }
    }
}
