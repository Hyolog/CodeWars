using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/56eb16655250549e4b0013f4/train/csharp"/>
    [TestClass]
    public class MostFrequentWeekdays
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new[] { "Friday", "Saturday" }, MostFrequentDays(2016));
            CollectionAssert.AreEqual(new[] { "Monday" }, MostFrequentDays(1770));
            CollectionAssert.AreEqual(new[] { "Monday" }, MostFrequentDays(2001));
            CollectionAssert.AreEqual(new[] { "Monday", "Tuesday" }, MostFrequentDays(1968));
            CollectionAssert.AreEqual(new[] { "Saturday" }, MostFrequentDays(1785));
            CollectionAssert.AreEqual(new[] { "Saturday" }, MostFrequentDays(1910));
            CollectionAssert.AreEqual(new[] { "Saturday" }, MostFrequentDays(2135));
            CollectionAssert.AreEqual(new[] { "Sunday" }, MostFrequentDays(3043));
            CollectionAssert.AreEqual(new[] { "Sunday" }, MostFrequentDays(3150));
            CollectionAssert.AreEqual(new[] { "Thursday" }, MostFrequentDays(3361));
            CollectionAssert.AreEqual(new[] { "Tuesday" }, MostFrequentDays(1901));
            CollectionAssert.AreEqual(new[] { "Tuesday" }, MostFrequentDays(3230));
            CollectionAssert.AreEqual(new[] { "Wednesday" }, MostFrequentDays(1794));
            CollectionAssert.AreEqual(new[] { "Wednesday" }, MostFrequentDays(1986));
        }

        public static string[] MostFrequentDays(int year)
        {
            var firstDay = new DateTime(year, 1, 1).DayOfWeek;
            var lastDay = new DateTime(year, 12, 31).DayOfWeek;

            return new DayOfWeek[] { firstDay, lastDay }.OrderBy(d => ((int)d + 6) % 7).Distinct().Select(d => d.ToString()).ToArray();
        }
    }
}
