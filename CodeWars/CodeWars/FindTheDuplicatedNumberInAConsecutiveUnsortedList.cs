using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/558f0553803bc3c4720000af/train/csharp"/>
    [TestClass]
    public class DefaultTeFindTheDuplicatedNumberInAConsecutiveUnsortedListmplate
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(FindDup(new int[] { 1, 2, 3, 1 }), 1);
            Assert.AreEqual(FindDup(new int[] { 1, 1 }), 1);
            Assert.AreEqual(FindDup(new int[] { 5, 4, 3, 2, 1, 1 }), 1);
            Assert.AreEqual(FindDup(new int[] { 1, 3, 2, 5, 4, 5, 7, 6 }), 5);
            Assert.AreEqual(FindDup(new int[] { 8, 2, 6, 3, 7, 2, 5, 1, 4 }), 2);
        }

        public static int FindDup(int[] arr)
        {
            var tempSet = new HashSet<int>();

            foreach (var item in arr)
            {
                if (tempSet.Contains(item))
                    return item;
                else
                    tempSet.Add(item);
            }

            throw new InvalidOperationException();
        }
    }
}
