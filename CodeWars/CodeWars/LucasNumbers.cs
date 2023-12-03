using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55a7de09273f6652b200002e/train/csharp"/>
    [TestClass]
    public class LucasNumbers
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(123, lucasnum(-10));
            Assert.AreEqual(-11, lucasnum(-5));
            Assert.AreEqual(-1, lucasnum(-1));
            Assert.AreEqual(2, lucasnum(0));
            Assert.AreEqual(1, lucasnum(1));
            Assert.AreEqual(11, lucasnum(5));
            Assert.AreEqual(123, lucasnum(10));
        }

        private static Dictionary<int, long> memo = new Dictionary<int, long>();


        public static long lucasnum(int n)
        {
            if (memo.ContainsKey(n))
                return memo[n];

            long result;

            if (n == 0)
                result = 2;
            else if (n == 1)
                result = 1;
            else if (n > 1)
                result = lucasnum(n - 1) + lucasnum(n - 2);
            else
                result = lucasnum(n + 2) - lucasnum(n + 1);

            memo[n] = result;
            return result;
        }
    }
}
