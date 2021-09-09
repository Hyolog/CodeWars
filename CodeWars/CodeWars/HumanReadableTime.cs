using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/52685f7382004e774f0001f7"/>
    [TestClass]
    public class HumanReadableTime
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("00:00:00", GetReadableTime(0));
            Assert.AreEqual("00:00:05", GetReadableTime(5));
            Assert.AreEqual("00:01:00", GetReadableTime(60));
            Assert.AreEqual("23:59:59", GetReadableTime(86399));
            Assert.AreEqual("99:59:59", GetReadableTime(359999));
        }

        public string GetReadableTime(int seconds)
        {
            var timeSpan = TimeSpan.FromSeconds(seconds);
            return string.Format("{0:00}:{1:00}:{2:00}", (int)timeSpan.TotalHours, timeSpan.Minutes, timeSpan.Seconds);
        }
    }
}
