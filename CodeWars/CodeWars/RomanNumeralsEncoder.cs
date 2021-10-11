using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/51b62bf6a9c58071c600001b/train/java"/>
    /// TODO:재밌는 문제. 한번쯤 다시 풀어보면 좋을듯
    [TestClass]
    public class RomanNumeralsEncoder
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("I", Solution(1));
            Assert.AreEqual("II", Solution(2));
            Assert.AreEqual("IV", Solution(4));
            Assert.AreEqual("D", Solution(500));
            Assert.AreEqual("MCMLIV", Solution(1954));
            Assert.AreEqual("MCMXC", Solution(1990));
            Assert.AreEqual("MMVIII", Solution(2008));
            Assert.AreEqual("MMXIV", Solution(2014));
        }

        public string Solution(int n)
        {
            var romanDic = new Dictionary<int, string>() { { 1000, "M" }, { 900, "CM" }, { 500, "D" }, { 400, "CD" }, { 100, "C" }, { 90, "XC" }, { 50, "L" }, { 40, "XL" }, { 10, "X" }, { 9, "IX" }, { 5, "V" }, { 4, "IV" }, { 1, "I" } };
            var keys = romanDic.Keys;
            var result = string.Empty;

            while (n > 0)
            {
                foreach (var key in keys)
                {
                    if (key <= n)
                    {
                        n -= key;
                        result += romanDic[key];
                        break;
                    }
                }
            }

            return result;
        }
    }
}
