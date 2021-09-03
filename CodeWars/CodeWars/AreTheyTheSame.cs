using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/550498447451fbbd7600041c"/>
    [TestClass]
    public class AreTheyTheSame
    {
        [TestMethod]
        public void Test()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            Assert.AreEqual(true, Comp(a, b));
            Assert.AreEqual(false, Comp(null, new int[] { 1 }));
            Assert.AreEqual(false, Comp(new int[] { 1 }, null));
            Assert.AreEqual(true, Comp(new int[] { 2, 2, 3 }, new int[] { 4, 9, 9 }));
            Assert.AreEqual(true, Comp(new int[] { 1 }, new int[] { 1 }));
            Assert.AreEqual(false, Comp(new int[] { 4, 4 }, new int[] { 1, 31 }));
            Assert.AreEqual(true, Comp(new int[] { -2 }, new int[] { 4 }));
            Assert.AreEqual(true, Comp(new int[] { -1 }, new int[] { 1 }));
        }

        public bool Comp(int[] a, int[] b)
        {
            int count = 0;

            if (a == null || b == null)
                return false;

            if (a.Length == 0 && b.Length == 0)
                return true;

            if (a.Length == 0 || b.Length == 0)
                return false;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] * a[i] == b[j])
                    {
                        b[j] = -1;
                        count++;
                        break;
                    }
                }
            }

            return count == a.Length;
        }
    }
}
