using NUnit.Framework;
using Num._39;

namespace Test
{
    [TestFixture]
    public class Num_39_Test
    {
        [ThisTestIsAnswer]
        [Test]
        [TestCase(new[] {1, 2, 3, 4, 5})]
        [TestCase(new[] {3, 2, 1, 4, 5})]
        public void HasArrayDuplicates_Returns_False_If_They_Are_Not_In_Array(int[] array)
        {
            Assert.IsFalse(Main.HasArrayDuplicates(array));
        }

        [ThisTestIsAnswer]
        [Test]
        [TestCase(new[] {1, 2, 3, 4, 1})]
        [TestCase(new[] {1, 2, 1, 4, 3})]
        [TestCase(new[] {1, 2, 5, 5, 2})]
        public void HasArrayDuplicates_Returns_True_If_They_Are_In_Array(int[] array)
        {
            Assert.IsTrue(Main.HasArrayDuplicates(array));
        }
    }
}