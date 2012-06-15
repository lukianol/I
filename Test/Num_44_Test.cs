using System;
using System.Collections.Generic;
using NUnit.Framework;
using Num._44;

namespace Test
{
    [TestFixture]
    public class Num_44_Test
    {
        [ThisTestIsAnswer]
        [Test]
        public void GetNumberOfOnes_Returns_1([ValueSource("IntsWithOneNumber")]int number)
        {
            var numberOfOnes = Main.GetNumberOfOnes(number);
            Assert.AreEqual(1, numberOfOnes);
        }

        [ThisTestIsAnswer]
        [Test]
        public void GetNumberOfOnes_Returns_3([ValueSource("IntsWithThreeNumbers")]int number)
        {
            var numberOfOnes = Main.GetNumberOfOnes(number);
            Assert.AreEqual(3, numberOfOnes);
        }

        [ThisTestIsAnswer]
        [Test]
        public void GetNumberOfOnes_Returns_0([Values(0)]int number)
        {
            var numberOfOnes = Main.GetNumberOfOnes(number);
            Assert.AreEqual(0, numberOfOnes);
        }

        public IEnumerable<int> IntsWithOneNumber
        {
            get 
            {
                yield return Convert.ToInt32("0001", 2);
                yield return Convert.ToInt32("0010", 2);
                yield return Convert.ToInt32("0100", 2);
            }
        }

        public IEnumerable<int> IntsWithThreeNumbers
        {
            get
            {
                yield return Convert.ToInt32("10000000110", 2);
                yield return Convert.ToInt32("1011", 2);
                yield return Convert.ToInt32("1110", 2);
            }
        }
    }
}
