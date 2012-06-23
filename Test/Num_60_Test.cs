using System.Linq;
using NUnit.Framework;
using Num._60;

namespace Test
{
    [TestFixture]
    public class Num_60_Test
    {
        [ThisTestIsAnswer]
        [Test]
        [TestCase(new[] {1, 3, 1, 4, 3, 5, 1, 2})]
        [TestCase(new[] {5, 2, 2, 5, 2, 4, 3, 2, 1})]
        public void CompressArray_Works(int[] array)
        {
            var actual = Main.CompressArray(array);
            Assert.AreEqual(array.Distinct(), actual);
        }
    }
}