using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/523f5d21c841566fde000009/train/csharp"/>
    [TestClass]
    public class ArrayDiff
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 2 }, Solution(new int[] { 1, 2, 2 }, new int[] { }));
            CollectionAssert.AreEqual(new int[] { 2 }, Solution(new int[] { 1, 2 }, new int[] { 1 }));
            CollectionAssert.AreEqual(new int[] { 2, 2 }, Solution(new int[] { 1, 2, 2 }, new int[] { 1 }));
            CollectionAssert.AreEqual(new int[] { 1 }, Solution(new int[] { 1, 2, 2 }, new int[] { 2 }));
            CollectionAssert.AreEqual(new int[] { }, Solution(new int[] { }, new int[] { 1, 2 }));
            CollectionAssert.AreEqual(new int[] { 3 }, Solution(new int[] { 1, 2, 3 }, new int[] { 1, 2 }));
        }

        public int[] Solution(int[] a, int[] b)
        {
            return a.Where(d => !b.Contains(d)).ToArray();
        }
    }
}
