using NUnit.Framework;
using Num._49;

namespace Test
{
    [TestFixture]
    public class Num_49_Test
    {
        [Test]
        [ThisTestIsAnswer]
        public void DoBackspace_Deletes_Ascii()
        {
            byte[] characters = {0x50, 0x56, 0x34, 0x34};
            var actual = Main.DoBackspace(characters, 3);
            CollectionAssert.AreEqual(new []{0x50, 0x56, 0x34}, actual);
        }

        [Test]
        [ThisTestIsAnswer]
        public void DoBackspace_Deletes_Kanji()
        {
            byte[] characters = { 0x50, 0x56, 0x84, 0x34 };
            var actual = Main.DoBackspace(characters, 3);
            CollectionAssert.AreEqual(new[] { 0x50, 0x34 }, actual);
        }
    }
}