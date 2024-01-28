using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5d6ee508aa004c0019723c1c/train/csharp"/>
    /// Todo : 다시 풀어보기
    [TestClass]
    public class OdderThanTheRest
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(1, Oddest(new int[] { 1, 2 }));
            Assert.AreEqual(3, Oddest(new int[] { 1, 3 }));
            Assert.AreEqual(null, Oddest(new int[] { 1, 5 }));
        }

        public static int? Oddest(int[] a)
        {
            if (a == null || a.Length == 0)
            {
                return null;
            }

            int? oddestNumber = null;
            int maxOddness = int.MinValue;
            bool hasUniqueMaxOddness = true;

            foreach (int num in a)
            {
                int oddness = CountSetBits(num);

                if (oddestNumber == null || oddness > maxOddness)
                {
                    maxOddness = oddness;
                    oddestNumber = num;
                    hasUniqueMaxOddness = true;
                }
                else if (oddness == maxOddness)
                {
                    hasUniqueMaxOddness = false;
                }
            }

            return hasUniqueMaxOddness ? oddestNumber : null;
        }

        private static int CountSetBits(int n)
        {
            int count = 0;

            while (n > 0)
            {
                count += n % 2;
                n /= 2;
            }

            return count;
        }
    }
}
