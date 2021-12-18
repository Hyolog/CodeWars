using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/54dc6f5a224c26032800005c/train/csharp"/>
    /// TODO : Linq로 다시 풀어보기
    [TestClass]
    public class HelpTheBookseller
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("(A : 200) - (B : 1140)", stockSummary(new string[] { "ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600" }, new String[] { "A", "B" }));
        }

        public string stockSummary(String[] lstOfArt, String[] lstOf1stLetter)
        {
            var stockInfos = new Dictionary<string, int>();

            foreach (var item in lstOf1stLetter)
                stockInfos.Add(item, 0);

            foreach (var target in lstOf1stLetter)
            {
                foreach (var stockInfo in lstOfArt)
                {
                    var candidate = stockInfo.Split(" ")[0][0];

                    if (candidate.ToString() == target)
                        stockInfos[target] += int.Parse(stockInfo.Split(" ")[1]);
                }
            }

            var result = new List<string>();

            foreach (var stockInfo in stockInfos)
                result.Add($"({stockInfo.Key} : {stockInfo.Value})");

            return stockInfos.Sum(d => d.Value) == 0 ? string.Empty : string.Join(" - ", result);
        }
    }
}
