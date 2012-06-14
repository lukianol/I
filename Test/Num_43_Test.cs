using NUnit.Framework;
using Num._43;

namespace Test
{
    [TestFixture]
    public class Num_43_Test
    {

        public static readonly object[] ExamplesOfSentencesAndReversedCopy = 
                                                            {
                                                                new object[] {"Hello world", "world Hello"},
                                                                new object[] {" London is a capital of Great Britain ", " Britain Great of capital a is London "}
                                                            };

        [ThisTestIsAnswer]
        [Test]
        [TestCaseSource("ExamplesOfSentencesAndReversedCopy")]
        public void ReverseWords_Really_Reverse_Them(string input, string reversed)
        {
            var inputChar = input.ToCharArray();
            Main.ReverseWords(inputChar);
            CollectionAssert.AreEqual(reversed, inputChar);
        }

    }
}
