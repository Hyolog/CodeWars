using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/52742f58faf5485cae000b9a/train/csharp"/>
    [TestClass]
    public class HumanReadableDurationFormat
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("now", formatDuration(0));
            Assert.AreEqual("1 second", formatDuration(1));
            Assert.AreEqual("1 minute and 2 seconds", formatDuration(62));
            Assert.AreEqual("2 minutes", formatDuration(120));
            Assert.AreEqual("1 hour, 1 minute and 2 seconds", formatDuration(3662));
            Assert.AreEqual("182 days, 1 hour, 44 minutes and 40 seconds", formatDuration(15731080));
            Assert.AreEqual("4 years, 68 days, 3 hours and 4 minutes", formatDuration(132030240));
            Assert.AreEqual("6 years, 192 days, 13 hours, 3 minutes and 54 seconds", formatDuration(205851834));
            Assert.AreEqual("8 years, 12 days, 13 hours, 41 minutes and 1 second", formatDuration(253374061));
            Assert.AreEqual("7 years, 246 days, 15 hours, 32 minutes and 54 seconds", formatDuration(242062374));
            Assert.AreEqual("3 years, 85 days, 1 hour, 9 minutes and 26 seconds", formatDuration(101956166));
            Assert.AreEqual("1 year, 19 days, 18 hours, 19 minutes and 46 seconds", formatDuration(33243586));
        }

        public static string GetReadableString(string str, int value)
        {
            return value == 1 ? $"{value} {str}" : $"{value} {str}s";
        }

        public static string formatDuration(int seconds)
        {
            if (seconds == 0)
                return "now";

            var stack = new Stack<string>();

            var second = seconds % 60;
            seconds -= second;

            if (second != 0)
                stack.Push(GetReadableString("second", second));

            int minutes = seconds / 60;
            var minute = minutes % 60;
            minutes -= minute;
            
            if (minute != 0)
                stack.Push(GetReadableString("minute", minute));

            int hours = minutes / 60;
            var hour = hours % 24;
            hours -= hour;

            if (hour != 0)
                stack.Push(GetReadableString("hour", hour));

            int days = hours / 24;
            var day = days % 365;
            days -= day;

            if (day != 0)
                stack.Push(GetReadableString("day", day));

            int years = days / 365;

            if (years != 0)
                stack.Push(GetReadableString("year", years));

            if (stack.Count == 1)
                return stack.Pop();
            else
            {
                string result = null;

                while (stack.Count > 2)
                {
                    result += $"{stack.Pop()}, ";
                }

                result += $"{stack.Pop()} and {stack.Pop()}";

                return result;
            }
        }
    }
}
