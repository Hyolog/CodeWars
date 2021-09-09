using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5552101f47fc5178b1000050"/>
    [TestClass]
    public class PlayingWithDigits
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(1, digPow(89, 1));
            Assert.AreEqual(-1, digPow(92, 1));
            Assert.AreEqual(51, digPow(46288, 3));
        }

        public long digPow(int n, int p)
        {
            var items = n.ToString();
            long sum = 0;

            for (int i = 0; i < items.Length; i++)
                sum += (long)Math.Pow(int.Parse(items[i].ToString()), p + i);

            return sum % n == 0 ? sum / n : -1;
        }
    }
}
