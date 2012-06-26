using System.Globalization;
using System.IO;
using NUnit.Framework;
using Num._41;

namespace Test
{
    [TestFixture]
    public class Num_41_Test
    {
        [ThisTestIsAnswer]
        [Test]
        public void PrintOutUlongCharByChar_Works()
        {
            using (var writer = new StringWriter())
            {
                const ulong value = 123152525623423423;
                Main.PrintOutUlongCharByChar(value, writer);
                Assert.AreEqual(value.ToString(CultureInfo.InvariantCulture), writer.ToString());
            }
        }
    }
}