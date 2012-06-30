using Common;
using NUnit.Framework;
using Num._48;

namespace Test
{
    [TestFixture]
    public class Num_48_Test
    {
        [Test]
        [ThisTestIsAnswer]
        public void AddToLinkedList_Works()
        {
            var linkedList = new LinkedList<int>();
            Main.AddToLinkedList(linkedList, 1);
            Main.AddToLinkedList(linkedList, 2);
            Main.AddToLinkedList(linkedList, 3);

            CollectionAssert.AreEqual(new []{1, 2, 3}, linkedList);
        }

        [Test]
        [ThisTestIsAnswer]
        public void AddToLinkedList_Works_WithIndex_In_The_Middle()
        {
            var linkedList = new LinkedList<int> {1, 3};
            Main.AddToLinkedList(linkedList, 2, 1);
            CollectionAssert.AreEqual(new[] { 1, 2, 3 }, linkedList);
        }

        [Test]
        [ThisTestIsAnswer]
        public void AddToLinkedList_Works_WithIndex_At_The_Start()
        {
            var linkedList = new LinkedList<int> { 2, 3 };
            Main.AddToLinkedList(linkedList, 1, 0);
            CollectionAssert.AreEqual(new[] { 1, 2, 3 }, linkedList);
        }

        [Test]
        [ThisTestIsAnswer]
        public void AddToLinkedList_Works_WithIndex_At_The_End()
        {
            var linkedList = new LinkedList<int> { 1, 2 };
            Main.AddToLinkedList(linkedList, 3, 2);
            CollectionAssert.AreEqual(new[] { 1, 2, 3 }, linkedList);
        }

        [Test]
        [ThisTestIsAnswer]
        public void DeleteFromLinkedList_Workds_At_The_End()
        {
            var linkedList = new LinkedList<int> { 1, 2,  3};
            Main.DeleteFromLinkedList(linkedList, 2);
            CollectionAssert.AreEqual(new []{1,2}, linkedList);
        }

        [Test]
        [ThisTestIsAnswer]
        public void DeleteFromLinkedList_Workds_At_The_Start()
        {
            var linkedList = new LinkedList<int> { 1, 2, 3 };
            Main.DeleteFromLinkedList(linkedList, 0);
            CollectionAssert.AreEqual(new[] { 2, 3 }, linkedList);
        }

        [Test]
        [ThisTestIsAnswer]
        public void DeleteFromLinkedList_Workds_In_The_Middle()
        {
            var linkedList = new LinkedList<int> { 1, 2, 3 };
            Main.DeleteFromLinkedList(linkedList, 1);
            CollectionAssert.AreEqual(new[] { 1, 3 }, linkedList);
        }

        [Test]
        [ThisTestIsAnswer]
        public void GetFromLinkedList_Workds_At_The_End()
        {
            var linkedList = new LinkedList<int> { 1, 2, 3 };
            var actual = Main.GetFromLinkedList(linkedList, 2);
            Assert.AreEqual(3, actual);
        }

        [Test]
        [ThisTestIsAnswer]
        public void GetFromLinkedList_Workds_At_The_Start()
        {
            var linkedList = new LinkedList<int> { 1, 2, 3 };
            var actual = Main.GetFromLinkedList(linkedList, 0);
            Assert.AreEqual(1, actual);
        }

        [Test]
        [ThisTestIsAnswer]
        public void GetFromLinkedList_Workds_In_The_Middle()
        {
            var linkedList = new LinkedList<int> { 1, 2, 3 };
            var actual = Main.GetFromLinkedList(linkedList, 1);
            Assert.AreEqual(2, actual);
        }

        

    }
}