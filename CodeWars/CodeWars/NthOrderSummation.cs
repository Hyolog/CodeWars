using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/60d5b5cd507957000d08e673/train/csharp"/>
    [TestClass]
    public class NthOrderSummation
    {

        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(1, S(0, 1)); 
            Assert.AreEqual(1, S(1, 1));
            Assert.AreEqual(1, S(0, 53));
            Assert.AreEqual(49, S(1, 49));
            Assert.AreEqual(286, S(10, 4));
        }

        private static Dictionary<Tuple<BigInteger, BigInteger>, BigInteger> memo = new Dictionary<Tuple<BigInteger, BigInteger>, BigInteger>();

        public static BigInteger S(BigInteger m, BigInteger n)
        {
            if (m == 0) return 1;

            var key = new Tuple<BigInteger, BigInteger>(m, n);
            if (memo.ContainsKey(key))
                return memo[key];

            BigInteger sum = 0;
            for (BigInteger i = 1; i <= n; i++)
            {
                sum += S(m - 1, i);
            }

            memo[key] = sum;
            return sum;
        }
    }
}
