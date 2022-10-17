using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5a045fee46d843effa000070/train/csharp"/>
    [TestClass]
    public class FactorialDecomposition
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(Decomp(17), "2^15 * 3^6 * 5^3 * 7^2 * 11 * 13 * 17");
            Assert.AreEqual(Decomp(5), "2^3 * 3 * 5");
            Assert.AreEqual(Decomp(22), "2^19 * 3^9 * 5^4 * 7^3 * 11^2 * 13 * 17 * 19");
            Assert.AreEqual(Decomp(14), "2^11 * 3^5 * 5^2 * 7^2 * 11 * 13");
            Assert.AreEqual(Decomp(25), "2^22 * 3^10 * 5^6 * 7^3 * 11^2 * 13 * 17 * 19 * 23");
        }

        public static string Decomp(int n)
        {
            var items = new Dictionary<int, int>();

            for (int i = 2; i <= n; i++)
            {
                var index = i;

                for (int j = 2; j <= index; j++)
                {
                    while (index % j == 0)
                    {
                        if (items.TryGetValue(j, out var count))
                            items[j]++;
                        else
                            items.Add(j, 1);

                        index /= j;
                    }
                }
            }

            return string.Join(" * ", items.Select(d => d.Value > 1 ? $"{d.Key}^{d.Value}" : $"{d.Key}"));
        }
    }
}
