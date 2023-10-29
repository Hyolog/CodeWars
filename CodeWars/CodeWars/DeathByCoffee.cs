using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/57db78d3b43dfab59c001abe/train/csharp"/>
    [TestClass]
    public class DeathByCoffee
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual((2645, 1162), CoffeeLimits(1950, 1, 19));
            Assert.AreEqual((0, 0), CoffeeLimits(1965, 9, 4));
        }

        private const int CAFE = 51966;
        private const int DECAF = 912559;

        public static (int, int) CoffeeLimits(int year, int month, int day)
        {
            List<int> cafesAllowed = new List<int>();
            List<int> decafsAllowed = new List<int>();

            string healthNumberStr = year.ToString("0000") + month.ToString("00") + day.ToString("00");
            long healthNumber = long.Parse(healthNumberStr);

            for (int i = 1; i <= 5000; i++)
            {
                long CAFE_total = healthNumber + (i * CAFE);
                long DECAF_total = healthNumber + (i * DECAF);

                string CAFE_hex_total = CAFE_total.ToString("X");
                string DECAF_hex_total = DECAF_total.ToString("X");

                if (CAFE_hex_total.Contains("DEAD"))
                {
                    cafesAllowed.Add(i);
                }
                if (DECAF_hex_total.Contains("DEAD"))
                {
                    decafsAllowed.Add(i);
                }
            }

            int cafesAllowedResult = (cafesAllowed.Count == 0) ? 0 : cafesAllowed[0];
            int decafsAllowedResult = (decafsAllowed.Count == 0) ? 0 : decafsAllowed[0];

            return (cafesAllowedResult, decafsAllowedResult);
        }
    }
}
