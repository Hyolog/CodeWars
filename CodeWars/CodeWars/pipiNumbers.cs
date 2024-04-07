using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Numerics;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5af27e3ed2ee278c2c0000e2/train/csharp"/>
    [TestClass]
    public class pipiNumbers
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(new BigInteger(0), pipi(0));
            Assert.AreEqual(new BigInteger(1), pipi(1));
            Assert.AreEqual(new BigInteger(9), pipi(2));
            Assert.AreEqual(new BigInteger(3025), pipi(3));
        }

        public static BigInteger pipi(int n)
        {
            if (n < Cache.Numbers.Count)
            {
                return Cache.Numbers[n];
            }

            BigInteger pn = new BigInteger(n);
            for (int i = 0; i < n; i++)
            {
                pn = pn - pipi(i);
                pn = pn * pn;
            }

            Cache.Numbers.Add(pn);
            return pn;
        }
    }

    class Cache
    {
        private Cache() { }
        public static List<BigInteger> Numbers { get; } = new List<BigInteger>();
    }
}
