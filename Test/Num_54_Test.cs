using System.IO;
using NUnit.Framework;
using Num._54;

namespace Test
{
    [TestFixture]
    public class Num_54_Test
    {
        [ThisTestIsAnswer]
        [Test]
        public void PrintInSpiralOder_Works()
        {
            int[,] array = {
                                 {1,2,3,4},
                                 {5,6,7,8},
                                 {9,10,11,12},
                                 {13,14,15,16},
                                 {17, 18, 19, 20}
                            };

            using (var writer = new StringWriter())
            {
                Main.PrintInSpiralOder(array, writer);                       
                Assert.AreEqual("1234812162019181713956711151410", writer.ToString());
            }



        }
    }
}