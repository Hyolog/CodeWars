using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/526233aefd4764272800036f/train/csharp"/>
    [TestClass]
    public class MatrixAddition
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new int[][] { new int[] { 3, 5 }, new int[] { 3, 5 } },
                MatrixAdditionFunc(new int[][] { new int[] { 1, 2 }, new int[] { 1, 2 } }, new int[][] { new int[] { 2, 3 }, new int[] { 2, 3 } }));
        }

        public static int[][] MatrixAdditionFunc(int[][] a, int[][] b)
        {
            var columnCount = a.Length;
            var rowCount = a[0].Length;
            var result = new int[columnCount][];

            for (int column = 0; column < columnCount; column++)
            {
                result[column] = new int[rowCount];

                for (int row = 0; row < rowCount; row++)
                    result[column][row] = a[column][row] + b[column][row];
            }

            return result;
        }
    }
}
