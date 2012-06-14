using System;
using System.Collections.Generic;
using NUnit.Framework;
using Num._42;

namespace Test
{
    [TestFixture]
    public class Num_42_Test
    {   
        [ThisTestIsAnswer]
        [Test]
        public void IsNumberPowerOfTwo_Returns_True_If_Number_Is_Power_Of_Two([ValueSource("PowersOfTwo")]int number)
        {
            Assert.IsTrue(Main.IsNumberPowerOfTwo(number));
        }

        [ThisTestIsAnswer]
        [Test]
        public void IsNumberPowerOfTwo_Returns_False_If_Number_Is_Not_Power_Of_Two([ValueSource("NotPowersOfTwo")]int number)
        {
            Assert.IsFalse(Main.IsNumberPowerOfTwo(number));
        }
        
        public IEnumerable<int> PowersOfTwo
        {
            get
            {
                for (var i = 0; i < 10; i++)
                    yield return (int)Math.Pow(2, i);
            }
        }

        public IEnumerable<int> NotPowersOfTwo
        {
            get 
            { 
                yield return 0;
                yield return 11;
                yield return 25;
                yield return 33;
                yield return 74;
                yield return 97;
            }
        }
    }
}
