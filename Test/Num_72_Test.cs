using System;
using System.Collections.Generic;
using System.Linq;
using Common;
using NUnit.Framework;
using Num._72;

namespace Test
{
    [TestFixture]
    public class Num_72_Test
    {
        [ThisTestIsAnswer]
        [Test]
        [TestCase("00110011110011000101010110101010")]
        [TestCase("00000000000000000000000000000001")]
        [TestCase("00000000000000000000000000000000")]
        public void SetHighestSignificantBitToZero_Works(string uintBinaryString)
        {
            var @uint = Convert.ToUInt32(uintBinaryString, 2);

            var highestSignificantBitToZero = Main.SetHighestSignificantBitToZero(@uint);

            var actual = highestSignificantBitToZero.ToBinaryString();

            var expected = EthalonReplaceSignificantBit(uintBinaryString);

            CollectionAssert.AreEqual(expected, actual);
        }

        private static string EthalonReplaceSignificantBit(string uintBinaryString)
        {
            var indexOf = uintBinaryString.IndexOf('1');
            if (indexOf == -1) return uintBinaryString;
            var charArray = uintBinaryString.ToCharArray();
            charArray[indexOf] = '0';
            return new string(charArray);
        }
    }
}