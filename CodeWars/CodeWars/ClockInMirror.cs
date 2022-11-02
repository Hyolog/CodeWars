using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/56548dad6dae7b8756000037/train/csharp"/>
    /// Todo : 다시 풀어보기
    [TestClass]
    public class ClockInMirror
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("06:35", WhatIsTheTime("05:25"));
            Assert.AreEqual("11:59", WhatIsTheTime("12:01"));
            Assert.AreEqual("12:02", WhatIsTheTime("11:58"));
            Assert.AreEqual("12:00", WhatIsTheTime("12:00"));
            Assert.AreEqual("02:00", WhatIsTheTime("10:00"));
        }

        public static string WhatIsTheTime(string timeInMirror)
        {
            var time = timeInMirror.Split(':');

            int hour;
            int minute;

            if (time[0] == "11")
                hour = 12;
            else if (time[0] == "12")
                hour = 11;
            else
                hour = 11 - int.Parse(time[0]);

            minute = 60 - int.Parse(time[1]);

            if (minute == 60)
            {
                hour++;
                minute = 0;
            }

            return string.Format("{0:00}:{1:00}", hour, minute);
        }
    }
}
