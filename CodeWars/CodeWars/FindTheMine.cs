using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/528d9adf0e03778b9e00067e/train/csharp"/>
    [TestClass]
    public class FindTheMine
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(new Tuple<int, int>(0, 0), MineLocation(new int[,] { { 1, 0 }, { 0, 0 } }));
            Assert.AreEqual(new Tuple<int, int>(0, 0), MineLocation(new int[,] { { 1, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } }));
            Assert.AreEqual(new Tuple<int, int>(2, 2), MineLocation(new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 0 } }));
        }

        public static Tuple<int, int> MineLocation(int[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == 1)
                    {
                        return new Tuple<int, int>(i, j);
                    }
                }
            }

            return null;
        }
    }
}
