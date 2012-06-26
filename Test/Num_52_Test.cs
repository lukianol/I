using NUnit.Framework;
using Num._52;

namespace Test
{
    [TestFixture]
    public class Num_52_Test
    {
        [ThisTestIsAnswer]
        [Test]
        [TestCase("el", "Hello world", "Ho word")]
        [TestCase("Freedom", ".NeT Rocks!", ".NT Rcks!")]
        public void RemoveCharacters_Works(string chars, string value, string expected)
        {
            string actual = Main.RemoveCharacters(chars, value);
            Assert.AreEqual(expected, actual);
        }
    }
}