using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/526571aae218b8ee490006f4/train/csharp"/>
    [TestClass]
    public class BitCounting
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(0, CountBits(0));
            Assert.AreEqual(1, CountBits(4));
            Assert.AreEqual(3, CountBits(7));
            Assert.AreEqual(2, CountBits(9));
            Assert.AreEqual(2, CountBits(10));
        }

        public int CountBits(int n)
        {
            var result = 0;

            while (n > 0)
            {
                if (n % 2 != 0)
                    result++;

                n /= 2;
            }

            return result;
        }
    }
}
