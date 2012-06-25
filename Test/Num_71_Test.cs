using System;
using NUnit.Framework;
using Num._71;

namespace Test
{
    [TestFixture]
    public class Num_71_Test
    {
        [ThisTestIsAnswer]
        [Test]
        [TestCase((uint)1)]
        [TestCase((uint)2)]
        [TestCase((uint)27)]
        [TestCase((uint)49)]
        [TestCase((uint)160)]
        [TestCase((uint)1284)]
        public void DiscreteLog2_Works(uint value)
        {
            var actual = Main.DiscreteLog2(value);
            var expected = Convert.ToUInt32(Math.Floor(Math.Log(value, 2)));
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void DiscreteLog2_Fails_OnZero()
        {
            Main.DiscreteLog2(0);
        }
    }
}