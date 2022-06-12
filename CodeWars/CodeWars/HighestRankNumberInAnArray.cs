using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5420fc9bb5b2c7fd57000004/train/csharp"/>
    [TestClass]
    public class HighestRankNumberInAnArray
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(10, HighestRank(new int[] { 3, 10, 8, 3, 10 }));
            Assert.AreEqual(12, HighestRank(new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12, 10 }));
        }

        public static int HighestRank(int[] arr)
        {
            var dic = new Dictionary<int, int>();

            foreach (var item in arr)
            {
                if (dic.TryGetValue(item, out var count))
                    dic[item]++;
                else
                    dic.Add(item, 1);
            }

            var max = dic.Max(d => d.Value);
            return dic.Where(d => d.Value == max).Select(d => d.Key).Max();
        }
    }
}
