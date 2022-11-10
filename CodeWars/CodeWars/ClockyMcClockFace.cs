using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59752e1f064d1261cb0000ec/train/csharp"/>
    [TestClass]
    public class ClockyMcClockFace
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("12:00", WhatTimeIsIt(0));
            Assert.AreEqual("03:00", WhatTimeIsIt(90));
            Assert.AreEqual("09:00", WhatTimeIsIt(270));
            Assert.AreEqual("01:30", WhatTimeIsIt(45));
        }

        public static string WhatTimeIsIt(double angle)
        {
            var realAngle = angle % 360;
            var time = (int)(realAngle / 30);
            var minute = realAngle % 30 * 2;

            return string.Format("{0:00}:{1:00}", time == 0 ? 12 : time, minute);
        }
    }
}
