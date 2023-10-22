using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59b8614a5227dd64dc000008/train/csharp"/>
    [TestClass]
    public class MinFactorDistance
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(1, MinDistance(8));
            Assert.AreEqual(4, MinDistance(25));
            Assert.AreEqual(2, MinDistance(13013));
            Assert.AreEqual(200, MinDistance(557009));
            Assert.AreEqual(198, MinDistance(218683));
        }

        public static int MinDistance(int n)
        {
            List<int> factors = GetFactors(n);

            int minDistance = int.MaxValue;

            for (int i = 1; i < factors.Count; i++)
            {
                int distance = factors[i] - factors[i - 1];
                if (distance < minDistance)
                {
                    minDistance = distance;
                }
            }

            return minDistance;
        }

        public static List<int> GetFactors(int n)
        {
            List<int> factors = new List<int>();
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    factors.Add(i);

                    if (i != n / i)
                    {
                        factors.Add(n / i);
                    }
                }
            }

            factors.Sort();
            return factors;
        }
    }
}
