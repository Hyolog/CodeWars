using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55e2adece53b4cdcb900006c/train/csharp"/>
    [TestClass]
    public class TortoiseRacing
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new int[] { 0, 32, 18 }, Race(720, 850, 70));
            CollectionAssert.AreEqual(new int[] { 3, 21, 49 }, Race(80, 91, 37));
            CollectionAssert.AreEqual(new int[] { 2, 0, 0 }, Race(80, 100, 40));
            CollectionAssert.AreEqual(new int[] { 0, 17, 4 }, Race(720, 850, 37));
            CollectionAssert.AreEqual(new int[] { 2, 50, 46 }, Race(720, 850, 370));
            CollectionAssert.AreEqual(new int[] { 0, 3, 2 }, Race(120, 850, 37));
            CollectionAssert.AreEqual(new int[] { 18, 20, 0 }, Race(820, 850, 550));
        }

        public static int[] Race(int v1, int v2, int g)
        {
            if (v1 >= v2)
                return null;

            var timeSpan = TimeSpan.FromHours((g / (double)(v2 - v1)));

            return new int[] { timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds };
        }
    }
}
