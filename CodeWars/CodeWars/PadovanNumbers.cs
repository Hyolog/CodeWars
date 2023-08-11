using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5803ee0ed5438edcc9000087/train/csharp"/>
    [TestClass]
    public class PadovanNumbers
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(1, Get(1));
        }

        private static Dictionary<long, long> memo = new Dictionary<long, long>()
        {
            {0, 1},
            {1, 1},
            {2, 1}
        };

        public long Get(int number)
        {
            if (memo.ContainsKey(number))
            {
                return memo[number];
            }

            long result = Get(number - 2) + Get(number - 3);
            memo[number] = result;

            return result;
        }
    }
}
