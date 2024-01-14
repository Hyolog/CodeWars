using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/656e4602ee72af0017e37e82/train/csharp"/>
    [TestClass]
    public class CuckooClock
    {
        [TestMethod]
        public void Test()
        {
            List<string> initialTimes = new List<string> { "07:22", "12:22", "01:30", "04:01", "03:38" };
            List<int> chimes = new List<int> { 1, 2, 2, 10, 19 };
            List<string> expectedTimes = new List<string> { "07:30", "12:45", "01:45", "05:30", "06:00" };

            for (int i = 0; i < initialTimes.Count; i++)
            {
                Assert.AreEqual(expectedTimes[i], CuckooClockFunc(initialTimes[i], chimes[i]));
            }
        }

        public static string CuckooClockFunc(string inputTime, int chimes)
        {
            string[] timeParts = inputTime.Split(':');
            int currentHour = int.Parse(timeParts[0]);
            int currentMinute = int.Parse(timeParts[1]);

            int chimeCount = 0;

            while (chimeCount < chimes)
            {
                if (currentMinute == 0)
                {
                    chimeCount += currentHour - 1;
                }

                if (currentMinute % 15 == 0)
                {
                    chimeCount++;
                }

                currentMinute++;

                if (currentMinute == 60)
                {
                    currentMinute = 0;
                    currentHour = (currentHour % 12) + 1;
                }
            }

            currentMinute--;

            if (currentMinute == 0)
            {
                return $"{currentHour.ToString().PadLeft(2, '0')}:00";
            }

            string resultHour = currentHour.ToString().PadLeft(2, '0');
            string resultMinute = currentMinute.ToString().PadLeft(2, '0');
            return $"{resultHour}:{resultMinute}";
        }
    }
}
