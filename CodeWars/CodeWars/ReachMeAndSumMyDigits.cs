using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55ffb44050558fdb200000a4/train/csharp"/>
    [TestClass]
    public class ReachMeAndSumMyDigits
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(SumDigNthTerm(10, new long[] { 2, 1, 3 }, 6), 10);
            Assert.AreEqual(SumDigNthTerm(10, new long[] { 2, 1, 3 }, 15), 10);
            Assert.AreEqual(SumDigNthTerm(10, new long[] { 2, 1, 3 }, 50), 9);
            Assert.AreEqual(SumDigNthTerm(10, new long[] { 2, 1, 3 }, 78), 10);
            Assert.AreEqual(SumDigNthTerm(10, new long[] { 2, 1, 3 }, 157), 7);
        }

        public static long SumDigNthTerm(long initval, long[] patternl, int nthterm)
        {
            long count = 1;
            var index = 0;

            while (count < nthterm)
            {
                initval += patternl[index];
                index++;
                count++;

                if (index >= patternl.Length)
                    index = 0;
            }

            long result = 0;

            foreach (var item in initval.ToString())
                result += long.Parse(item.ToString());

            return result;
        }
    }
}
