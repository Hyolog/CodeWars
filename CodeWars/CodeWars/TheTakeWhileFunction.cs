using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/54f9173aa58bce9031001548/train/csharp"/>
    [TestClass]
    public class TheTakeWhileFunction
    {
        [TestMethod]
        public void Test()
        {
            Func<int, bool> isEven = (num) => num % 2 == 0;

            CollectionAssert.AreEqual(new int[0], TakeWhile(new int[0], isEven));
            CollectionAssert.AreEqual(new int[] { 2, 6, 4, 10 }, TakeWhile(new int[] { 2, 6, 4, 10, 1, 5, 4, 3 }, isEven));
            CollectionAssert.AreEqual(new int[] { 998, 996, 12, -1000, 200, 0 }, TakeWhile(new int[] { 998, 996, 12, -1000, 200, 0, 1, 1, 1 }, isEven));
            CollectionAssert.AreEqual(new int[] { 2, 4, 10, 100, 64, 78, 92 }, TakeWhile(new int[] { 2, 4, 10, 100, 64, 78, 92 }, isEven));
        }

        public static int[] TakeWhile(int[] arr, Func<int, bool> pred)
        {
            int count = 0;
            while (count < arr.Length && pred(arr[count]))
                count++;

            return arr[..count];
        }
    }
}
