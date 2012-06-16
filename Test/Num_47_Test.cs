using System;
using NUnit.Framework;
using Num._47;

namespace Test
{
    [TestFixture]
    public class Num_47_Test
    {
        [Test]
        [Repeat(25)]
        [ThisTestIsAnswer("Actually I would not say that Main.MultiplyBy is faster than the usual '*' is." +
                          "But seems this is only way to do such an operation differently than using '*'")]
        public void Test()
        {
            unchecked
            {
                var i = new Random().Next(int.MinValue, int.MaxValue);
                var actual = Main.MultiplyBy7(i);
                Assert.AreEqual(i * 7, actual);
            }
        }
     }
}
