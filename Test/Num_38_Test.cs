using System.Diagnostics;
using NUnit.Framework;
using Num._38;

namespace Test
{
    [TestFixture]
    public class Num_38_Test
    {
        public static readonly object[] ExamplesOfArrayAndSubArrays =
            {
                new object[] {new[] {1, 2, 3, 4, 5}, new[] {1, 2, 3, 4, 5}},
                new object[] {new[] {-1, -2, -3, -4, -5}, new[] {-1}},
                new object[] {new[] {-3, -4, -1, -2, -5}, new[] {-1}},
                new object[] {new[] {-5, -4, -3, -2, -1}, new[] {-1}},
                new object[] {new[] {1, -2, 3, -4, 5}, new[] {5}},
                new object[] {new[] {-1, 2, -3, 4, -5}, new[] {4}},
                new object[] {new[] {-1, 2, -3, -5, 4}, new[] {4}},
                new object[] {new[] {-1, -2, -3, 4, 5}, new[] {4, 5}},
                new object[] {new[] {-1, 2, 3, 4, -5}, new[] {2, 3, 4}},
                new object[] {new[] {2, 1, -2, 5, 2, 0}, new[] {2, 1, -2, 5, 2}}
            };

        private static readonly CalibratingSubArrayWithLargestSumStrategy CalibratingSubArrayWithLargestSumStrategy =
            new CalibratingSubArrayWithLargestSumStrategy();

        private static readonly LinearSubArrayWithLargestSumStrategy LinearSubArrayWithLargestSumStrategy =
            new LinearSubArrayWithLargestSumStrategy();

        [Test]
        [TestCaseSource("ExamplesOfArrayAndSubArrays")]
        [Ignore(
            "Calibrating strategy was used to check the linear startegy. This strategy itself is greater than required O(n)"
            )]
        public void CalibratingSubArrayWithLargestSumStrategy_Finds_Correct_SubArray(int[] input, int[] output)
        {
            int[] subArrayWithLargestSum = Main.GetSubArrayWithLargestSum(input,
                                                                          CalibratingSubArrayWithLargestSumStrategy);
            CollectionAssert.AreEqual(output, subArrayWithLargestSum);
        }

        [Test]
        [Repeat(100)]
        [Ignore(
            "This test is used to compare Calibrating vs. Linear strategy. It has a random nature and may fail because of trailing zeros and zero expressions"
            )]
        public void Calibrating_vs_Linear()
        {
            var random = new Randomizer();
            int[] array = random.GetInts(-100, 100, random.Next(2, 10));
            Trace.TraceInformation("Array: {0}", array.ToArrayString());
            int[] expected = Main.GetSubArrayWithLargestSum(array, CalibratingSubArrayWithLargestSumStrategy);
            Trace.TraceInformation("Expected: {0}", expected.ToArrayString());
            int[] actual = Main.GetSubArrayWithLargestSum(array, LinearSubArrayWithLargestSumStrategy);
            Trace.TraceInformation("Actual: {0}", actual.ToArrayString());
            CollectionAssert.AreEqual(expected, actual);
        }

        [ThisTestIsAnswer]
        [Test]
        [TestCaseSource("ExamplesOfArrayAndSubArrays")]
        [Description("This LinearSubArrayWithLargestSumStrategy is an answer to the question Num. 38")]
        public void LinearSubArrayWithLargestSumStrategy_Finds_Correct_SubArray(int[] input, int[] output)
        {
            int[] subArrayWithLargestSum = Main.GetSubArrayWithLargestSum(input, LinearSubArrayWithLargestSumStrategy);
            CollectionAssert.AreEqual(output, subArrayWithLargestSum);
        }
    }
}