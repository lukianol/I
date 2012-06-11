using NUnit.Framework;
using Num._38;

namespace Test
{
    [TestFixture]
    public class Num_38_Test
    {
        [Test]
        public void GetSubArrayWithLargestSum_Finds_That_SubArray()
        {
            var ints = new[] {-4, 1, 2, 3, -5};
            var subArrayWithLargestSum = Main.GetSubArrayWithLargestSum(ints);
            CollectionAssert.AreEqual(new []{ 1, 2, 3 }, subArrayWithLargestSum);
        }
    }
}
