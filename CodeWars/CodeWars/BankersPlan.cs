using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/56445c4755d0e45b8c00010a/train/csharp"/>
    [TestClass]
    public class BankersPlan
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(Fortune(100000, 1, 2000, 15, 1), true);
            Assert.AreEqual(Fortune(100000, 1, 9185, 12, 1), false);
            Assert.AreEqual(Fortune(100000000, 1, 100000, 50, 1), true);
            Assert.AreEqual(Fortune(100000000, 1.5, 10000000, 50, 1), false);
            Assert.AreEqual(Fortune(100000000, 5, 1000000, 50, 1), true);
            Assert.AreEqual(Fortune(9999, 61.8161, 10000, 3, 0), true);
        }

        public static Boolean Fortune(int f0, double p, int c0, int n, double i)
        {
            int[][] data = new int[n][];
            data[0] = new int[] { f0, c0 };

            for (int j = 1; j < n; j++)
            {
                int f = (int)(data[j - 1][0] * (1 + p / 100) - data[j - 1][1]);
                int c = (int)(data[j - 1][1] * (1 + i / 100));
                data[j] = new int[] { f, c };

                if (f < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
