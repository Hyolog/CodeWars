using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5d5a7525207a674b71aa25b5/train/csharp"/>
    [TestClass]
    public class RowOfTheOddTriangle
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(OddRow(1), new long[] { 1 });
            CollectionAssert.AreEqual(OddRow(2), new long[] { 3, 5 });
            CollectionAssert.AreEqual(OddRow(13), new long[] { 157, 159, 161, 163, 165, 167, 169, 171, 173, 175, 177, 179, 181 });
            CollectionAssert.AreEqual(OddRow(19), new long[] { 343, 345, 347, 349, 351, 353, 355, 357, 359, 361, 363, 365, 367, 369, 371, 373, 375, 377, 379 });
            CollectionAssert.AreEqual(OddRow(2809381), new long[] { 1 });
        }

        public static long[] OddRow(int n)
        {
            // 계차수열
            long[] result = new long[n];

            var num = (long)n;

            for (int i = 0; i < num; i++)
            {
                result[i] = (long)(num * num - num + 1 + 2 * i);
            }

            return result;
        }
    }
}
