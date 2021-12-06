using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/53db96041f1a7d32dc0004d2/train/csharp"/>
    [TestClass]
    public class DidIFinishMySudoku
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(DoneOrNot(new int[][]
            {
              new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
              new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
              new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
              new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
              new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
              new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
              new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
              new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
              new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
            }), "Finished!");
            Assert.AreEqual(DoneOrNot(new int[][]
            {
              new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
              new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
              new int[] {1, 9, 8, 3, 0, 2, 5, 6, 7},
              new int[] {8, 5, 0, 7, 6, 1, 4, 2, 3},
              new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
              new int[] {7, 0, 3, 9, 2, 4, 8, 5, 6},
              new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
              new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
              new int[] {3, 0, 0, 2, 8, 6, 1, 7, 9},
            }), "Try again!");
        }

        public static string DoneOrNot(int[][] board)
        {
            // row check
            for (int rowIndex = 0; rowIndex < 9; rowIndex++)
            {
                var row = board[rowIndex];

                if (!IsValid(row))
                    return "Try again!";
            }

            // column check
            for (int columnIndex = 0; columnIndex < 9; columnIndex++)
            {
                var columnItems = new List<int>();

                for (int rowIndex = 0; rowIndex < 9; rowIndex++)
                    columnItems.Add(board[rowIndex][columnIndex]);

                if (!IsValid(columnItems.ToArray()))
                    return "Try again!";
            }

            // square check
            for (int i = 0; i < 9; i++)
            {
                int x = 3 * (i / 3);
                int y = 3 * (i % 3);

                var squareItems = new List<int>();

                for (int rowIndex = x; rowIndex < x + 3; rowIndex++)
                    for (int columnIndex = y; columnIndex < y + 3; columnIndex++)
                        squareItems.Add(board[rowIndex][columnIndex]);

                if (!IsValid(squareItems.ToArray()))
                    return "Try again!";
            }

            return "Finished!";
        }

        private static bool IsValid(int[] row)
        {
            return row.Distinct().Sum() == 45;
        }
    }
}
