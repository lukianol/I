using Common;
using NUnit.Framework;
using Num._51;

namespace Test
{
    [TestFixture]
    public class Num_51_Test
    {
        [TestFixtureSetUp]
        public void InitBinaryTree()
        {
            _tree = new BinaryTree<string>
                        {
                            Root = new BinaryTreeNode<string>("[1]")
                                       {
                                           Left = new BinaryTreeNode<string>("[1;1]")
                                                      {
                                                          Left = new BinaryTreeNode<string>("[1;1;1]")
                                                          ,
                                                          Right = new BinaryTreeNode<string>("[1;1;2]")
                                                      }
                                           ,
                                           Right = new BinaryTreeNode<string>("[1;2]")
                                                       {
                                                           Left = new BinaryTreeNode<string>("[1;2;1]")
                                                                      {
                                                                          Right =
                                                                              new BinaryTreeNode<string>(
                                                                              "I am with depth equals 4!")
                                                                      }
                                                           ,
                                                           Right = new BinaryTreeNode<string>("[1;2;2]")
                                                       }
                                       }
                        };
        }

        private BinaryTree<string> _tree;

        [ThisTestIsAnswer]
        [Test]
        public void DepthOfBinaryTree_Works()
        {
            var actual = Main.DepthOfBinaryTree(_tree);
            Assert.AreEqual(4, actual);
        }
    }
}