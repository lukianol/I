using System;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;
using Num._58;

namespace Test
{
    [TestFixture]
    public class Num_58_Test
    {
        [Test]
        [TestCase(new[] {1, 1, 2, 6, 4, 6})]
        [TestCase(new[] {1, 2, 1, 4, 6, 6, 7, 7, 9})]
        [ExpectedException(typeof (ArgumentException))]
        public void GetUniqueElements_Fails_If_List_Is_Not_Sorted(int[] source)
        {
            Debug.Assert(source != null, "source != null");

            var actual = Main.GetUniqueElements(source);
            CollectionAssert.AreEqual(source.Distinct(), actual);
        }

        [ThisTestIsAnswer]
        [Test]
        [TestCase(new[] {1, 1, 2, 4, 6, 6})]
        [TestCase(new[] {1, 1, 2, 4, 6, 6, 7, 7, 9})]
        public void GetUniqueElements_Returns_Unqiue_Elements_If_List_Is_Sorted(int[] source)
        {
            Debug.Assert(source != null, "source != null");

            var actual = Main.GetUniqueElements(source);
            CollectionAssert.AreEqual(source.Distinct(), actual);
        }
    }
}