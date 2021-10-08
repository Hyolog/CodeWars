using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/56a5d994ac971f1ac500003e/train/csharp"/>
    [TestClass]
    public class ConsecutiveStrings
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2), "abigailtheta");
            Assert.AreEqual(LongestConsec(new String[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1), "oocccffuucccjjjkkkjyyyeehh");
            Assert.AreEqual(LongestConsec(new String[] { }, 3), "");
            Assert.AreEqual(LongestConsec(new String[] { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" }, 2), "wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck");
            Assert.AreEqual(LongestConsec(new String[] { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" }, 2), "wlwsasphmxxowiaxujylentrklctozmymu");
            Assert.AreEqual(LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas" }, -2), "");
            Assert.AreEqual(LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3), "ixoyx3452zzzzzzzzzzzz");
            Assert.AreEqual(LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 15), "");
            Assert.AreEqual(LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 0), "");
        }

        public String LongestConsec(string[] strarr, int k)
        {
            if (k == 0 || strarr.Length < k)
                return "";

            var resultIndex = 0;
            var resultLength = 0;

            for (int i = 0; i < strarr.Count() - k + 1; i++)
            {
                var tempLength = 0;

                for (int j = i; j <  i + k; j++)
                    tempLength += strarr[j].Length;

                if (tempLength > resultLength)
                {
                    resultLength = tempLength;
                    resultIndex = i;
                }
            }

            return string.Join("", strarr.Skip(resultIndex).Take(k));
        }
    }
}
