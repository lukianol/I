using NUnit.Framework;
using Num._57;

namespace Test
{
    [TestFixture]
    public class Num_57_Test
    {

        [ThisTestIsAnswer]
        [Test]
        public void Test()
        {
            var actual = Main.ToUppercase("Hello world!");
            Assert.AreEqual("HELLO WORLD!", actual);
        }
    }
}
