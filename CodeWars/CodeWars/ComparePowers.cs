using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55b2549a781b5336c0000103/train/csharp"/>
    [TestClass]
    public class ComparePowers
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(ComparePowersFunc(new int[] { 2, 10 }, new int[] { 2, 15 }), 1);
            Assert.AreEqual(ComparePowersFunc(new int[] { 2, 10 }, new int[] { 2, 10 }), 0);
            Assert.AreEqual(ComparePowersFunc(new int[] { 7, 7 }, new int[] { 5, 8 }), -1);
        }

        public static int ComparePowersFunc(int[] a, int[] b)
        {
            double f = Math.Log10(a[0]) * a[1];
            double s = Math.Log10(b[0]) * b[1];

            return f == s ? 0 : (f > s ? -1 : 1);
        }
    }
}
