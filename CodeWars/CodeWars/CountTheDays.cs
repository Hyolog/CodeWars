using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5837fd7d44ff282acd000157/train/csharp"/>
    [TestClass]
    public class CountTheDays
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("The day is in the past!", countDays(new DateTime(2016, 12, 2)));
            Assert.AreEqual("Today is the day!", countDays(DateTime.Now));
        }

        public string countDays(DateTime d)
        {
            DateTime today = DateTime.Now;

            if (d.Date == today.Date)
                return "Today is the day!";

            if (d < today)
                return "The day is in the past!";

            TimeSpan timeDifference = d - today;
            return $"{Math.Round(timeDifference.TotalDays)} days";
        }
    }
}
