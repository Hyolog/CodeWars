using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5a906c895084d7ed740000c2/train/csharp"/>
    [TestClass]
    public class SimpleNumberTriangle
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(Solve(4), 14L);
            Assert.AreEqual(Solve(5), 42L);
            Assert.AreEqual(Solve(6), 132L);
            Assert.AreEqual(Solve(8), 1430L);
            Assert.AreEqual(Solve(20), 6564120420L);
        }

        public static BigInteger Solve(int n)
        {
            if (n <= 0) return 0;

            BigInteger[][] triangle = new BigInteger[n][];

            for (int i = 0; i < n; i++)
            {
                triangle[i] = new BigInteger[i + 1];
                triangle[i][0] = 1;
                for (int j = 1; j < i; j++)
                {
                    triangle[i][j] = triangle[i - 1][j] + triangle[i][j - 1];
                }

                if (i > 0)
                {
                    triangle[i][i] = triangle[i][i - 1];
                }
            }

            BigInteger sumLastRow = 0;
            for (int j = 0; j < triangle[n - 1].Length; j++)
            {
                sumLastRow += triangle[n - 1][j];
            }

            return sumLastRow;
        }
    }
}
