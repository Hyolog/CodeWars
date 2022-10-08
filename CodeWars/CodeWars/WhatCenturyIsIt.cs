using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/52fb87703c1351ebd200081f/train/csharp"/>
    [TestClass]
    public class WhatCenturyIsIt
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("20th", WhatCentury("1999"), "With input '1999' solution produced wrong output.");
            Assert.AreEqual("21st", WhatCentury("2011"), "With input '2011' solution produced wrong output.");
            Assert.AreEqual("22nd", WhatCentury("2154"), "With input '2154' solution produced wrong output.");
            Assert.AreEqual("23rd", WhatCentury("2259"), "With input '2259' solution produced wrong output.");
        }

        public static string WhatCentury(string year)
        {
            var yearNum = int.Parse(year);
            yearNum -= 1;

            var century = int.Parse(yearNum.ToString().Substring(0, 2)) + 1;

            if (century % 10 == 1)
            {
                return century == 11 ? $"{century}th" : $"{century}st";
            }
            else if (century % 10 == 2)
            {
                return century == 12 ? $"{century}th" : $"{century}nd";
            }
            else if (century % 10 == 3)
            {
                return century == 13 ? $"{century}th" : $"{century}rd";
            }

            return $"{century}th";
        }
    }
}
