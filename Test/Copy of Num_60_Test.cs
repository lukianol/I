using NUnit.Framework;
using Num._63;

namespace Test
{
    [TestFixture]
    public class Num_63_Test
    {
        [ThisTestIsAnswer]
        [Test]
        [TestCase(new[] { "john", "peter", "kent", "steve" }, "john")]
        [TestCase(new[] { "thomas", "manuel", "atkin", "corn" }, "atkin")]
        public void LargestAndSmallestLexString_Finds_Smallest_Lex(string[] array, string expectedSmallest)
        { 
            string actualSmallest, actualLargest;
            Main.LargestAndSmallestLexStringFromArray(array, out actualSmallest, out actualLargest);
            Assert.AreEqual(expectedSmallest, actualSmallest);
        }

        [ThisTestIsAnswer]
        [Test]
        [TestCase(new[] { "john", "peter", "kent", "steve" }, "steve")]
        [TestCase(new[] { "thomas", "manuel", "atkin", "corn" }, "thomas")]
        public void LargestAndSmallestLexString_Finds_Largest_Lex(string[] array, string expectedLargest)
        {
            string actualSmallest, actualLargest;
            Main.LargestAndSmallestLexStringFromArray(array, out actualSmallest, out actualLargest);
            Assert.AreEqual(expectedLargest, actualLargest);
        }
    }
}