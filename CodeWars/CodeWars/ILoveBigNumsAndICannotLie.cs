using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/56121f3312baa28c8500005b/train/csharp"/>
    [TestClass]
    public class ILoveBigNumsAndICannotLie
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("321", Biggest(new[] { 1, 2, 3 }));
            Assert.AreEqual("12121", Biggest(new[] { 121, 12 }));
            Assert.AreEqual("12812", Biggest(new[] { 12, 128 }));
            Assert.AreEqual("505150", Biggest(new[] { 5051, 50 }));
            Assert.AreEqual("10110", Biggest(new[] { 10, 101 }));
            Assert.AreEqual("9534330", Biggest(new[] { 3, 30, 34, 5, 9 }));
        }

        public static string Biggest(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return "";

            string[] strs = nums.Select(n => n.ToString()).ToArray();

            Array.Sort(strs, (a, b) =>
            {
                string order1 = a + b;
                string order2 = b + a;

                return order2.CompareTo(order1);
            });

            if (strs[0] == "0") return "0";

            return string.Join("", strs);
        }

    }
}
