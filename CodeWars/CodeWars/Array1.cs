using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5514e5b77e6b2f38e0000ca9/train/csharp"/>
    [TestClass]
    public class Array1
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new int[] { 4, 3, 2, 6 }, UpArray(new int[] { 4, 3, 2, 5 }));
            CollectionAssert.AreEqual(new int[] { 2, 4, 0 }, UpArray(new int[] { 2, 3, 9 }));
            CollectionAssert.AreEqual(new int[] { 1, 0, 0 }, UpArray(new int[] { 9, 9 }));
            CollectionAssert.AreEqual(null, UpArray(new int[] { }));
            CollectionAssert.AreEqual(null, UpArray(new int[] { 10, 9 }));
            CollectionAssert.AreEqual(null, UpArray(new int[] { -1, 9 }));
            CollectionAssert.AreEqual(null, UpArray(new int[] { -5, 10, 5, -1, 13, 6, 14, 4, 4, 9 }));
        }

        public static int[] UpArray(int[] num)
        {
            if (num == null || num.Length == 0 || num.Any(d => d < 0 || d > 9))
                return null;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                num[i] += 1;

                if (num[i] == 10)
                    num[i] = 0;
                else
                    return num;
            }

            var result = new int[num.Length + 1];
            result[0] = 1;

            return result;
        }
    }
}
