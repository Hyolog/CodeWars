using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5aec1ed7de4c7f3517000079/train/csharp"/>
    [TestClass]
    public class NSmallestElementsInOriginalOrder
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new[] { 1, 2, 3 }, FirstNSmallest(new[] { 1, 2, 3, 4, 5 }, 3));
            CollectionAssert.AreEqual(new[] { 3, 2, 1 }, FirstNSmallest(new[] { 5, 4, 3, 2, 1 }, 3));
            CollectionAssert.AreEqual(new[] { 1, 2, 1 }, FirstNSmallest(new[] { 1, 2, 3, 1, 2 }, 3));
            CollectionAssert.AreEqual(new[] { 1, -4, 0 }, FirstNSmallest(new[] { 1, 2, 3, -4, 0 }, 3));
            CollectionAssert.AreEqual(new int[0], FirstNSmallest(new[] { 1, 2, 3, 4, 5 }, 0));
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, FirstNSmallest(new[] { 1, 2, 3, 4, 5 }, 5));
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 2 }, FirstNSmallest(new[] { 1, 2, 3, 4, 2 }, 4));
            CollectionAssert.AreEqual(new[] { 2, 1 }, FirstNSmallest(new[] { 2, 1, 2, 3, 4, 2 }, 2));
            CollectionAssert.AreEqual(new[] { 2, 1, 2 }, FirstNSmallest(new[] { 2, 1, 2, 3, 4, 2 }, 3));
            CollectionAssert.AreEqual(new[] { 2, 1, 2, 2 }, FirstNSmallest(new[] { 2, 1, 2, 3, 4, 2 }, 4));
        }

        public static int[] FirstNSmallest(int[] arr, int n)
        {
            var list = new List<KeyValuePair<int, int>>();

            for (int i = 0; i < arr.Length; i++)
            {
                list.Add(new KeyValuePair<int, int>(arr[i], i));
            }

            var orderedList = list.OrderBy(d => d.Key).Take(n).Select(d => d.Value).OrderBy(d => d).ToArray();

            var result = new int[n];

            for (int i = 0; i < orderedList.Length; i++)
            {
                result[i] = arr[orderedList[i]];
            }

            return result;
        }
    }
}
