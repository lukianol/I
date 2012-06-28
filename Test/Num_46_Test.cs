using System.Collections.Generic;
using NUnit.Framework;
using Num._46;

namespace Test
{
    [TestFixture]
    public class Num_46_Test
    {
        [ThisTestIsAnswer]
        [Test]
        public void InsertInSortedList_Works()
        {
            var list = new List<int> {1,2,3,5};
            Main.InsertInSortedList(list, 4);
            CollectionAssert.AreEqual(new List<int> {1, 2, 3, 4, 5}, list);
        }
    }
}