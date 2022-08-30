using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/527e4141bb2ea5ea4f00072f/train/csharp"/>
    [TestClass]
    public class TwistedSum
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(6, TwistedSum.Solution(3));
            Assert.AreEqual(46, TwistedSum.Solution(10));
            Assert.AreEqual(51, TwistedSum.Solution(12));
            Assert.AreEqual(48, TwistedSum.Solution(11));
            Assert.AreEqual(17703, TwistedSum.Solution(1376));
        }

        public static long Solution(long n)
        {
            long sum = 0;

            for (int i = 1; i <= n; i++)
            {
                var num = i;

                while (num > 9)
                {
                    sum += num % 10;
                    num /= 10;
                }

                sum += num;
            }

            return sum;
        }
    }
}
