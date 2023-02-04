using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/559b8e46fa060b2c6a0000bf/train/csharp"/>
    [TestClass]
    public class EasyDiagonal
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(new BigInteger(8), diagonal(7, 0));
            Assert.AreEqual(new BigInteger(28), diagonal(7, 1));
            Assert.AreEqual(new BigInteger(5985), diagonal(20, 3));
            Assert.AreEqual(new BigInteger(20349), diagonal(20, 4));
            Assert.AreEqual(new BigInteger(54264), diagonal(20, 5));
        }

        public static BigInteger diagonal(int n, int p)
        {
            return GetNumber(n + 1, p + 1);
        }

        public static BigInteger GetNumber(int a, int b)
        {
            if (b == 0 || a == b)
                return 1;
            else
                return GetNumber(a - 1, b - 1) + GetNumber(a - 1, b);
        }
    }
}
