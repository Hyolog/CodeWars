using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5547cc7dcad755e480000004/train/csharp"/>
    [TestClass]
    public class IsMyFriendCheating
    {
        [TestMethod]
        public void Test()
        {
            List<long[]> r = new List<long[]> {
                new long[] { 15, 21 },
                new long[] { 21, 15 }
            };
            CollectionAssert.AreEqual(r, removNb(26));
            CollectionAssert.AreEqual(new long[0], removNb(100));
        }

        public static List<long[]> removNb(long n)
        {
            List<long[]> result = new List<long[]>();
            var sum = n * (n + 1) / 2;

            for (double b = n; b > 0; b--)
            {
                // a * b = sum - a - b
                // a * b + a = sum - b
                // a(b + 1) = sum - b
                // a = (sum - b) / (b + 1)
                var a = (sum - b) / (b + 1);

                if (a % 1 == 0 && a <= n)
                {
                    result.Add(new long[] { (long)a, (long)b });
                }
            }

            return result;
        }
    }
}
