using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55a5c82cd8e9baa49000004c/train/csharp"/>
    [TestClass]
    public class CountTheDivisibleNumbers
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(3, DivisibleCount(6, 11, 2));
        }

        public static long DivisibleCount(long x, long y, long k)
        {
            if (k == 0)
                return 0;

            long lowerBound = (x % k == 0) ? x : ((x / k) + 1) * k;
            long upperBound = (y / k) * k;

            if (lowerBound > upperBound)
                return 0;

            long count = ((upperBound - lowerBound) / k) + 1;

            return count;
        }
    }
}
