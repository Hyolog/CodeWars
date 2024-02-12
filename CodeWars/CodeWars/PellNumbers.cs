using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Numerics;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5818d00a559ff57a2f000082/train/csharp"/>
    [TestClass]
    public class PellNumbers
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(new BigInteger(1), Get(1));
            Assert.AreEqual(new BigInteger(12), Get(4));
            Assert.AreEqual(new BigInteger(985), Get(9));
            Assert.AreEqual(new BigInteger(470832), Get(16));
        }

        List<BigInteger> memo = new List<BigInteger> { 0, 1 };

        public BigInteger Get(int number)
        {
            if (number > memo.Count - 1)
            {
                memo.Add(2 * Get(number - 1) + Get(number - 2));
            }

            return memo[number];
        }
    }
}
