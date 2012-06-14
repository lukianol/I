using NUnit.Framework;
using Num._39;

namespace Test
{
    [TestFixture]
    public class Num_39_Test
    {   
        [ThisTestIsAnswer]
        [Test]
        [TestCase(new[]{1, 2, 3, 4,5}, false)]
        [TestCase(new[] { 1, 2, 3, 4, 1 }, true)]
        [TestCase(new[] { 1, 2, 1, 4, 3 }, true)]
        [TestCase(new[] { 1, 2, 5, 5, 2 }, true)]
        [TestCase(new[] { 3, 2, 1, 4, 5 }, false)]
        public void Test(int[] array, bool expected)
        {
            var actual = Main.HasArrayDuplicates(array);
            Assert.AreEqual(expected, actual);
        }

    }
}
