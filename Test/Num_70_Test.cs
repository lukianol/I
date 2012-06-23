using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Num._70;

namespace Test
{
    [TestFixture]
    public class Num_70_Test
    {
        [ThisTestIsAnswer]
        [Test]
        public void ReverseTheBits_Works()
        {
            const string uintBinaryString = "00110011110011000101010110101010";
            uint @uint = Convert.ToUInt32(uintBinaryString, 2);

            var uintWithReversedBits = Main.ReverseTheBits(@uint);

            var actual = uintWithReversedBits.ToBinaryString();
            IEnumerable<char> expected = uintBinaryString
                .Reverse();

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}