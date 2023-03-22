using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/562e274ceca15ca6e70000d3/train/csharp"/>
    [TestClass]
    public class ParabolicArcLength
    {
        [TestMethod]
        public void Test()
        {
            assertFuzzyEquals(lenCurve(1), 1.414213562);
            assertFuzzyEquals(lenCurve(10), 1.478197397);
        }

        private static void assertFuzzyEquals(double act, double exp)
        {
            bool inrange = Math.Abs((act - exp) / exp) <= 1e-6;
            if (inrange == false)
            {
                act = Math.Floor(act * 1e6) / 1e6;
                exp = Math.Floor(exp * 1e6) / 1e6;
            }
            Assert.AreEqual(true, inrange);

        }

        public static double lenCurve(int n)
        {
            var xs = new double[n + 1];
            double gap = 1.0 / n;
            xs[0] = 0;

            // get x
            for (int i = 1; i < xs.Length; i++)
            {
                xs[i] = xs[i - 1] + gap;
            }

            var ys = new double[n + 1];

            // get y
            for (int i = 0; i < ys.Length; i++)
            {
                ys[i] = GetY(xs[i]);
            }

            // get distances sum
            double distanceSum = 0;

            for (int i = 0; i < xs.Length - 1; i++)
            {
                distanceSum += GetDistance(xs[i], ys[i], xs[i + 1], ys[i + 1]);
            }

            return distanceSum;
        }

        private static double GetY(double x)
        {
            return Math.Pow(x, 2);
        }

        private static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Pow(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2), 0.5);
        }
    }
}
