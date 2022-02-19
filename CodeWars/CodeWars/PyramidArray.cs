using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/515f51d438015969f7000013/train/csharp"/>
    [TestClass]
    public class PyramidArray
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new int[][] { }, Pyramid(0));
            CollectionAssert.AreEqual(new int[][] { new int[] { 1 } }, Pyramid(1));
            CollectionAssert.AreEqual(new int[][] { new int[] { 1 }, new int[] { 1, 1 } }, Pyramid(2));
            CollectionAssert.AreEqual(new int[][] { new int[] { 1 }, new int[] { 1, 1 }, new int[] { 1, 1, 1 } }, Pyramid(3));
        }

        public static int[][] Pyramid(int n)
        {
            if (n == 0)
                return new int[0][];

            int[][] result = new int[n][];

            for (int i = 0; i < n; i++)
            {
                List<int> tempResult = new List<int>();

                for (int j = 0; j <= i; j++)
                    tempResult.Add(1);

                result[i] = tempResult.ToArray();
            }

            return result;
        }
    }
}
