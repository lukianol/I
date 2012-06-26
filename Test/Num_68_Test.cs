using System.IO;
using Common;
using NUnit.Framework;
using Num._68;

namespace Test
{
    [TestFixture]
    public class Num_68_Test
    {
       [TestFixtureSetUp]
       public void InitBinaryTree()
       {
           /*
            *        [1]
            *       /    \
            *  [1;1]         [1;2]
            * /     \             / \
            *[1;1;1] [1;1;2]  [1;2;1] [1;2;2]
            *
            */

           _tree = new BinaryTree<string>
                       {
                           Root = new BinaryTreeNode<string>("[1]")
                                      {
                                          Left = new BinaryTreeNode<string>("[1;1]")
                                                     {
                                                         Left = new BinaryTreeNode<string>("[1;1;1]")
                                                         , Right = new BinaryTreeNode<string>("[1;1;2]")
                                                     }
                                          , Right = new BinaryTreeNode<string>("[1;2]")
                                              {
                                                            Left = new BinaryTreeNode<string>("[1;2;1]")
                                                            , Right = new BinaryTreeNode<string>("[1;2;2]")
                                                        }
                                      }
                       };
       
       }

       [Test]
       public void PreorderTraversal_Works()
        {
            using(var stringWriter = new StringWriter())
            {
                Main.PreorderTraversal(_tree, stringWriter);
                Assert.AreEqual("[1][1;1][1;1;1][1;1;2][1;2][1;2;1][1;2;2]", stringWriter.ToString());
            }
        }

       [Test]
       public void InorderTraversal_Works()
       {
           using (var stringWriter = new StringWriter())
           {
               Main.InorderTraversal(_tree, stringWriter);
               Assert.AreEqual("[1;1;1][1;1][1;1;2][1][1;2;1][1;2][1;2;2]", stringWriter.ToString());
           }
       }

       [Test]
       public void PostorderTraversal_Works()
       {
           using (var stringWriter = new StringWriter())
           {
               Main.PostorderTraversal(_tree, stringWriter);
               Assert.AreEqual("[1;1;1][1;1;2][1;1][1;2;1][1;2;2][1;2][1]", stringWriter.ToString());
           }
       }


        private BinaryTree<string> _tree;
    }
}