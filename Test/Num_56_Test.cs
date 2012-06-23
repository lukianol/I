using System.Linq;
using NUnit.Framework;
using Num._56;

namespace Test
{
    [TestFixture]
    public class Num_56_Test
    {
        [ThisTestIsAnswer("This test may fall because of its random nature" +
                          "Use allowableNumberOfUnshuffledCards const inside " +
                          "the method to turn its result")]
        [Test]
        public void ShufflePack_Works_Randomly()
        {
            const int allowableNumberOfUnshuffledCards = 5; // you can turn this option to make the test pass

            Card[] packToShuffle = Main.GetNewPack();
            Main.ShufflePack(packToShuffle);
            Card[] packToCheck = Main.GetNewPack();
            Main.ShufflePack(packToCheck);
            Assert.AreEqual(packToShuffle.Length, packToCheck.Length);
            int unshuffledCount = packToCheck.Where((t, i) => packToShuffle[i] == t).Count();
            Assert.GreaterOrEqual(allowableNumberOfUnshuffledCards, unshuffledCount);
        }
    }
}