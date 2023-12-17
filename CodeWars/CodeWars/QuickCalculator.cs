using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Numerics;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55b22ef242ad87345c0000b2/train/csharp"/>
    [TestClass]
    public class QuickCalculator
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(new BigInteger(1), Choose(1, 1));
            Assert.AreEqual(new BigInteger(5), Choose(5, 4));
            Assert.AreEqual(new BigInteger(252), Choose(10, 5));
            Assert.AreEqual(new BigInteger(0), Choose(10, 20));
            Assert.AreEqual(new BigInteger(2598960), Choose(52, 5));
        }

        public static BigInteger Choose(int n, int p)
        {
            if (n < 0 || p < 0 || p > n)
                return 0;

            p = Math.Min(p, n - p);

            BigInteger result = 1;

            for (int i = 0; i < p; i++)
            {
                result *= (n - i);
                result /= (i + 1);
            }

            return result;
        }
    }
}
