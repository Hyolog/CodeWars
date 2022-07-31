using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55b3425df71c1201a800009c/train/csharp"/>
    [TestClass]
    public class StatisticsForAnAthleticAssociation
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("Range: 01|01|18 Average: 01|38|05 Median: 01|32|34", stat("01|15|59, 1|47|16, 01|17|20, 1|32|34, 2|17|17"));
            Assert.AreEqual("Range: 00|31|17 Average: 02|26|18 Median: 02|22|00", stat("02|15|59, 2|47|16, 02|17|20, 2|32|34, 2|17|17, 2|22|00, 2|31|41"));
        }

        public static string stat(string strg)
        {
            if (string.IsNullOrWhiteSpace(strg))
                return strg;

            var results = strg.Replace(" ", "").Split(',').Select(d => GetTotalSecond(d)).OrderBy(d => d).ToList();

            var range = GetHMSString(results[results.Count - 1] - results[0]);
            var average = GetHMSString(results.Sum() / results.Count);
            var median = GetHMSString(results.Count % 2 == 0 ?
                (results[results.Count / 2 - 1] + results[results.Count / 2]) / 2 : results[results.Count / 2]);

            return $"Range: {range} Average: {average} Median: {median}";
        }

        // hh|mm|ss -> ss
        private static int GetTotalSecond(string hms)
        {
            var items = hms.Split('|').Select(d => int.Parse(d)).ToArray();

            return ((items[0] * 60) + items[1]) * 60 + items[2];
        }

        // ss -> hh|mm|ss
        private static string GetHMSString(int second)
        {
            var s = (second % 60).ToString();
            var totalM = second / 60;
            var m = (totalM % 60).ToString();
            var h = (totalM / 60).ToString();

            if (s.Length == 1)
                s = "0" + s;
            if (m.Length == 1)
                m = "0" + m;
            if (h.Length == 1)
                h = "0" + h;

            return $"{h}|{m}|{s}";
        }
    }
}
