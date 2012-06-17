using NUnit.Framework;
using Num._50;

namespace Test
{
    [TestFixture]
    public class Num_50_Test
    {
        [ThisTestIsAnswer]
        [Test]
        [TestCase(new[]{ 1, 2, 3, 4, 5}, 4, new []{1, 2, 3, 5})]
        [TestCase(new[] { 6 }, 6, new int[]{})]
        [TestCase(new[] { 2,1,3,4 }, 2, new[]{1,3,4})]
        [TestCase(new[] { 2, 1, 3, 3 }, 3, new[] { 2, 1 })]
        [TestCase(new[] { 2, 1, 1, 4 }, 1, new[] { 2, 4 })]
        [TestCase(new int[] { }, 5, new int[] { })]
        public void Test(int[] values, int elementToDelete, int[] expected)
        {
            var list = new DoubledLinkedList<int>(values);
            list.Delete(elementToDelete);
            CollectionAssert.AreEqual(expected, list);
        }
    }
}
