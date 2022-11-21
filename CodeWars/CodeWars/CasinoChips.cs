using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5e0b72d2d772160011133654/train/csharp"/>
    [TestClass]
    public class CasinoChips
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(1, solve(new int[] { 1, 1, 1 }));
            Assert.AreEqual(2, solve(new int[] { 1, 2, 1 }));
            Assert.AreEqual(2, solve(new int[] { 4, 1, 1 }));
            Assert.AreEqual(9, solve(new int[] { 8, 2, 8 }));
            Assert.AreEqual(5, solve(new int[] { 8, 1, 4 }));
            Assert.AreEqual(10, solve(new int[] { 7, 4, 10 }));
            Assert.AreEqual(18, solve(new int[] { 12, 12, 12 }));
            Assert.AreEqual(3, solve(new int[] { 1, 23, 2 }));
        }

        public static int solve(int[] arr)
        {
            var result = 0;

            while (arr.Count(d => d <= 0) < 2)
            {
                arr = arr.OrderBy(d => d).ToArray();

                var gap = arr[1] - (Math.Max(arr[0] - 1, 0));
                arr[2] -= gap;
                arr[1] -= gap;
                result += gap;
            }

            return result;
        }
    }
}
