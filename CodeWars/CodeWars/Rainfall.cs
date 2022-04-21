using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/56a32dd6e4f4748cc3000006/train/csharp"/>
    [TestClass]
    public class Rainfall
    {
        private static string data =
         "Rome:Jan 81.2,Feb 63.2,Mar 70.3,Apr 55.7,May 53.0,Jun 36.4,Jul 17.5,Aug 27.5,Sep 60.9,Oct 117.7,Nov 111.0,Dec 97.9" +
         "\n" +
         "London:Jan 48.0,Feb 38.9,Mar 39.9,Apr 42.2,May 47.3,Jun 52.1,Jul 59.5,Aug 57.2,Sep 55.4,Oct 62.0,Nov 59.0,Dec 52.9" +
         "\n" +
         "Paris:Jan 182.3,Feb 120.6,Mar 158.1,Apr 204.9,May 323.1,Jun 300.5,Jul 236.8,Aug 192.9,Sep 66.3,Oct 63.3,Nov 83.2,Dec 154.7" +
         "\n" +
         "NY:Jan 108.7,Feb 101.8,Mar 131.9,Apr 93.5,May 98.8,Jun 93.6,Jul 102.2,Aug 131.8,Sep 92.0,Oct 82.3,Nov 107.8,Dec 94.2" +
         "\n" +
         "Vancouver:Jan 145.7,Feb 121.4,Mar 102.3,Apr 69.2,May 55.8,Jun 47.1,Jul 31.3,Aug 37.0,Sep 59.6,Oct 116.3,Nov 154.6,Dec 171.5" +
         "\n" +
         "Sydney:Jan 103.4,Feb 111.0,Mar 131.3,Apr 129.7,May 123.0,Jun 129.2,Jul 102.8,Aug 80.3,Sep 69.3,Oct 82.6,Nov 81.4,Dec 78.2" +
         "\n" +
         "Bangkok:Jan 10.6,Feb 28.2,Mar 30.7,Apr 71.8,May 189.4,Jun 151.7,Jul 158.2,Aug 187.0,Sep 319.9,Oct 230.8,Nov 57.3,Dec 9.4" +
         "\n" +
         "Tokyo:Jan 49.9,Feb 71.5,Mar 106.4,Apr 129.2,May 144.0,Jun 176.0,Jul 135.6,Aug 148.5,Sep 216.4,Oct 194.1,Nov 95.6,Dec 54.4" +
         "\n" +
         "Beijing:Jan 3.9,Feb 4.7,Mar 8.2,Apr 18.4,May 33.0,Jun 78.1,Jul 224.3,Aug 170.0,Sep 58.4,Oct 18.0,Nov 9.3,Dec 2.7" +
         "\n" +
         "Lima:Jan 1.2,Feb 0.9,Mar 0.7,Apr 0.4,May 0.6,Jun 1.8,Jul 4.4,Aug 3.1,Sep 3.3,Oct 1.7,Nov 0.5,Dec 0.7";

        private static string[] towns = new string[] {"Rome", "London", "Paris", "NY", "Vancouver", "Sydney", "Bangkok", "Tokyo",
        "Beijing", "Lima", "Montevideo", "Caracas", "Madrid", "Berlin"};

        public static void assertFuzzyEquals(double act, double exp)
        {
            bool inrange = Math.Abs(act - exp) <= 1e-2;

            if (inrange == false)
                Console.WriteLine("abs(actual - expected) must be <= 1e-2. Expected was " + exp + ", but got " + act);
            
            Assert.AreEqual(true, inrange);
        }

        [TestMethod]
        public void Test()
        {
            assertFuzzyEquals(Rainfall.Mean("London", data), 51.199999999999996);
            assertFuzzyEquals(Rainfall.Mean("Beijing", data), 52.416666666666664);
            assertFuzzyEquals(Rainfall.Variance("London", data), 57.42833333333374);
            assertFuzzyEquals(Rainfall.Variance("Beijing", data), 4808.37138888889);
        }

        private static string GetTownRainInfo(string town, string strng)
        {
            foreach (string item in strng.Split('\n'))
            {
                string[] splitted = item.Split(':');
                var townName = splitted[0];
                var rainInfo = splitted[1];

                if (townName == town)
                    return rainInfo;
            }

            return string.Empty;
        }

        public static double Mean(string town, string strng)
        {
            var townRainInfo = GetTownRainInfo(town, strng);

            if (string.IsNullOrEmpty(townRainInfo))
            {
                return -1;
            }
            else
            {
                double sumOfRain = 0;
                var countOfMonth = 0;

                foreach (var rainInfos in townRainInfo.Split(','))
                {
                    if (double.TryParse(rainInfos.Split(' ')[1], out var rain))
                    {
                        countOfMonth++;
                        sumOfRain += rain;
                    }
                }

                return sumOfRain / countOfMonth;
            }
        }

        public static double Variance(string town, string strng)
        {
            var mean = Mean(town, strng);
            var townRainInfo = GetTownRainInfo(town, strng);

            double sum = 0;
            int countOfMonth = 0;

            if (string.IsNullOrEmpty(townRainInfo))
            {
                return -1;
            }
            else
            {
                foreach (string rainInfos in townRainInfo.Split(','))
                {
                    if (double.TryParse(rainInfos.Split(' ')[1], out var rain))
                    {
                        countOfMonth++;
                        sum += (double)Math.Pow(rain - mean, 2);
                    }
                }

                return sum / countOfMonth;
            }
        }
    }
}