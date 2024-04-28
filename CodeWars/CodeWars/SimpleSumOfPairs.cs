using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5bc027fccd4ec86c840000b7/train/csharp"/>
    [TestClass]
    public class SimpleSumOfPairs
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(0, solve(0));
            Assert.AreEqual(1, solve(1));
            Assert.AreEqual(18, solve(18)); // 9 + 9
            Assert.AreEqual(11, solve(29)); // 14 + 15
            Assert.AreEqual(33, solve(1140));
            Assert.AreEqual(68, solve(50000000));
            Assert.AreEqual(144, solve(15569047737));
            Assert.AreEqual(116, solve(2452148459));
        }

        public static int solve(long n)
        {
            if (n < 10)
                return (int)n;

            long maxA = (long)Math.Pow(10, Math.Floor(Math.Log10(n)));
            long a = maxA - 1;
            long b = n - a;
            string digitsA = a.ToString();
            string digitsB = b.ToString();
            int sum = 0;

            foreach (char digit in digitsA)
            {
                sum += int.Parse(digit.ToString());
            }

            foreach (char digit in digitsB)
            {
                sum += int.Parse(digit.ToString());
            }

            return sum;
        }
    }
}
