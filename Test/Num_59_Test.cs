using System;
using NUnit.Framework;
using Num._59;

namespace Test
{
    [TestFixture]
    public class Num_59_Test
    {
        [Test]
        [TestCase(new[] {0, 3, 4, 5, 2}, 5)]
        [TestCase(new[] {5, 4, 3, 2, 1}, 4)]
        [ExpectedException(typeof (ArgumentException))]
        public void Sort_Throws_An_Exception(int[] array, int k)
        {
            Main.Sort(array, k);
        }

        [ThisTestIsAnswer]
        [Test]
        [TestCase(new[] {1, 3, 4, 5, 2}, 5)]
        [TestCase(new[] {5, 4, 3, 2, 1}, 5)]
        public void Sort_Works(int[] array, int k)
        {
            Main.Sort(array, k);

            var expected = (int[]) array.Clone();
            Array.Sort(expected);

            CollectionAssert.AreEqual(expected, array);
        }
    }
}