using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/587a88a208236efe8500008b/train/csharp"/>
    /// TODO : Sequence 수가 1인 일부케이스에 대해 테스트케이스가 0을 기대해 문의 남겨둠
    [TestClass]
    public class SumOfASequence
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(12, SequenceSum(2, 6, 2));
            Assert.AreEqual(15, SequenceSum(1, 5, 1));
            Assert.AreEqual(5, SequenceSum(1, 5, 3));
            Assert.AreEqual(-5, SequenceSum(-1, -5, -3));
            Assert.AreEqual(0, SequenceSum(16, 15, 3));
            Assert.AreEqual(-26, SequenceSum(-24, -2, 22));
            Assert.AreEqual(-2, SequenceSum(-2, 4, 658));
            Assert.AreEqual(469436517521190, SequenceSum(780, 68515438, 5));
            Assert.AreEqual(-15, SequenceSum(5, -10, -3));
            Assert.AreEqual(-27888, SequenceSum(33, -709, -9));
            Assert.AreEqual(-5, SequenceSum(-5, -5, -58));
            Assert.AreEqual(4, SequenceSum(4, 4, -65));
            Assert.AreEqual(-7, SequenceSum(-7, -7, 243));
        }

        public static long SequenceSum(long start, long end, long step)
        {
            long result = 0;

            if (start > end && step > 0)
                return 0;
            if (start < end && step < 0)
                return 0;

            long length = 0;
            var tempStart = start;

            if (step > 0)
            {
                while (tempStart <= end)
                {
                    length++;
                    tempStart += step;
                }
            }
            else
            {
                while (tempStart >= end)
                {
                    length++;
                    tempStart += step;
                }
            }

            var temp = length - 1;

            end = temp * step + start;

            result += (start + end) * length / 2;

            return result;
        }
    }
}
