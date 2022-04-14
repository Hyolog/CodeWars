using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/526989a41034285187000de4/train/csharp"/>
    [TestClass]
    public class CountIPAddresses
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(50, CountIPAddresses.IpsBetween("10.0.0.0", "10.0.0.50"));
            Assert.AreEqual(246, CountIPAddresses.IpsBetween("20.0.0.10", "20.0.1.0"));
            Assert.AreEqual((1L << 32) - 1L, CountIPAddresses.IpsBetween("0.0.0.0", "255.255.255.255"));
        }

        public static long IpsBetween(string start, string end)
        {
            var value = new long[4] { (1L << 24), (1L << 16), (1L << 8), 1L };
            var from = start.Split('.');
            var to = end.Split('.');
            long result = 0;

            for (int i = 0; i < from.Length; i++)
                result += ((long.Parse(from[i]) - long.Parse(to[i])) * value[i]);

            return Math.Abs(result);
        }
    }
}
