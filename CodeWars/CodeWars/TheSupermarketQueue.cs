using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/57b06f90e298a7b53d000a86/train/csharp"/>
    [TestClass]
    public class TheSupermarketQueue
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(0, QueueTime(new int[] { }, 1));
            Assert.AreEqual(10, QueueTime(new int[] { 1, 2, 3, 4 }, 1));
            Assert.AreEqual(9, QueueTime(new int[] { 2, 2, 3, 3, 4, 4 }, 2));
            Assert.AreEqual(57, QueueTime(new int[] { 12, 17, 12, 1, 13, 2, 16, 4, 15, 20, 2, 4, 4, 13, 9, 19, 10, 12, 18, 16, 19, 16, 7 }, 5));
            Assert.AreEqual(146, QueueTime(new int[] { 14, 8, 5, 13, 15, 7, 10, 15, 10, 8, 3, 20, 13, 13, 11, 7, 5, 8, 2, 18, 18, 20, 2, 7, 10, 19, 20, 3, 6, 2, 20, 11, 20, 7, 15, 19, 1, 2, 16 }, 3));
        }

        public static long QueueTime(int[] customers, int n)
        {
            var lines = new int[n];

            foreach (var customer in customers)
            {
                var minValue = lines.Min();
                var minIndex = Array.IndexOf(lines, minValue);

                lines[minIndex] += customer;
            }

            return lines.Max();
        }
    }
}
