using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59fa8e2646d8433ee200003f/train/csharp"/>
    [TestClass]
    public class SortingByBits
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(SortByBit(new[] { 3, 8, 3, 6, 5, 7, 9, 1 }), new[] { 1, 8, 3, 3, 5, 6, 9, 7 });
            CollectionAssert.AreEqual(SortByBit(new[] { 9, 4, 5, 3, 5, 7, 2, 56, 8, 2, 6, 8, 0 }), new[] { 0, 2, 2, 4, 8, 8, 3, 5, 5, 6, 9, 7, 56 });
        }

        public static int[] SortByBit(int[] array)
        {
            return array.OrderBy(d => Convert.ToString(d, 2).Count(a => a == '1')).ThenBy(d => d).ToArray();
        }
    }
}
