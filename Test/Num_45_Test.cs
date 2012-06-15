using NUnit.Framework;
using Num._45;

namespace Test
{
    [TestFixture]
    public class Num_45_Test
    {
        [Test]
        public void Test()
        {
            var start = new LinkedNode<int>(1)
                            {
                                Next = new LinkedNode<int>(2)
                                        {
                                            Next = new LinkedNode<int>(3)
                                                       {
                                                           Next = new LinkedNode<int>(4)
                                                                      {
                                                                          Next = new LinkedNode<int>(5)
                                                                      }
                                                       }
                                        }
                            };

            Main.ReverseList(start);
        }
    }
}
