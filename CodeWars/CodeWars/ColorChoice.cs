using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55be10de92aad5ef28000023/train/csharp"/>
    [TestClass]
    public class ColorChoice
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(2, Checkchoose(6, 4));
            Assert.AreEqual(1, Checkchoose(4, 4));
            Assert.AreEqual(3, Checkchoose(35, 7));
            Assert.AreEqual(-1, Checkchoose(4, 2));
            Assert.AreEqual(-1, Checkchoose(36, 7));
        }

        public static long Checkchoose(long m, int n)
        {
            for (int x = 0; x <= n; x++)
            {
                long combinations = BinomialCoefficient(n, x);
                if (combinations == m)
                    return x;
            }

            return -1;
        }

        private static long BinomialCoefficient(int n, int k)
        {
            if (k == 0 || k == n)
                return 1;

            long[,] coefficients = new long[n + 1, k + 1];

            for (int i = 0; i <= n; i++)
            {
                coefficients[i, 0] = 1;

                for (int j = 1; j <= Math.Min(i, k); j++)
                {
                    coefficients[i, j] = coefficients[i - 1, j - 1] + coefficients[i - 1, j];
                }
            }

            return coefficients[n, k];
        }
    }
}
