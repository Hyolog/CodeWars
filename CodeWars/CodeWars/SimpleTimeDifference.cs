using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5b76a34ff71e5de9db0000f2/train/csharp"/>
    [TestClass]
    public class SimpleTimeDifference
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("23:59", solve(new String[] { "14:51" }));
            Assert.AreEqual("09:10", solve(new String[] { "21:14", "15:34", "14:51", "06:25", "15:30" }));
            Assert.AreEqual("11:40", solve(new String[] { "23:00", "04:22", "18:05", "06:24" }));
        }

        public static string solve(string[] arr)
        {
            int[] minutes = arr.Select(time => Convert.ToInt32(time.Split(':')[0]) * 60 + Convert.ToInt32(time.Split(':')[1])).ToArray();

            Array.Sort(minutes);

            int maxDiff = 0;
            for (int i = 0; i < minutes.Length - 1; i++)
            {
                int diff = minutes[i + 1] - minutes[i] - 1;
                maxDiff = Math.Max(maxDiff, diff);
            }

            int diffBetweenFirstAndLast = (24 * 60 - minutes[minutes.Length - 1]) + minutes[0] - 1;
            maxDiff = Math.Max(maxDiff, diffBetweenFirstAndLast);

            return $"{maxDiff / 60:D2}:{maxDiff % 60:D2}";
        }
    }
}
