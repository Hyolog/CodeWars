using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/569d488d61b812a0f7000015/train/csharp"/>
    [TestClass]
    public class DataReverse
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new int[32] { 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 },
                DataReverseFunc(new int[32] { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0 }));
            CollectionAssert.AreEqual(new int[16] { 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0 },
                DataReverseFunc(new int[16] { 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1 }));
        }

        public static int[] DataReverseFunc(int[] data)
        {
            var result = new int[data.Length];
            var sourceIndex = data.Length - 8;

            for (int i = 0; i < data.Length; i += 8)
            {
                Array.Copy(data, sourceIndex, result, i, 8);
                sourceIndex -= 8;
            }

            return result;
        }
    }
}
