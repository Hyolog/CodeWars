using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/529bf0e9bdf7657179000008/train/csharp"/>
    [TestClass]
    public class SudokuSolutionValidator
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(true, ValidateSolution(new int[][]
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
        }));
            Assert.AreEqual(false, ValidateSolution(new int[][]
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
        }));
            Assert.AreEqual(false, ValidateSolution(new int[][]
        {
            new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
            new int[] {2, 3, 1, 5, 6, 4, 8, 9, 7},
            new int[] {3, 1, 2, 6, 4, 5, 9, 7, 8},
            new int[] {4, 5, 6, 7, 8, 9, 1, 2, 3},
            new int[] {5, 6, 4, 8, 9, 7, 2, 3, 1},
            new int[] {6, 4, 5, 9, 7, 8, 3, 1, 2},
            new int[] {7, 8, 9, 1, 2, 3, 4, 5, 6},
            new int[] {8, 9, 7, 2, 3, 1, 5, 6, 4},
            new int[] {9, 7, 8, 3, 1, 2, 6, 4, 5}
        }));
        }

        public bool ValidateSolution(int[][] board)
        {
            var sudokuLength = board.GetLength(0);

            // row check
            for (int rowIndex = 0; rowIndex < sudokuLength; rowIndex++)
                if (!IsValidLine(board[rowIndex]))
                    return false;

            // column check
            for (int rowIndex = 0; rowIndex < sudokuLength; rowIndex++)
            {
                var column = new int[sudokuLength];

                for (int columnIndex = 0; columnIndex < sudokuLength; columnIndex++)
                    column[columnIndex] = board[columnIndex][rowIndex];

                if (!IsValidLine(column))
                    return false;
            }

            // 3x3 sub grid check
            for (int i = 0; i < sudokuLength; i += 3)
            {
                var member = new int[sudokuLength];

                for (int j = 0; j < 3; j++)
                    for (int k = 0; k < 3; k++)
                        member[j * 3 + k] = board[i + j][i + k];

                if (!IsValidLine(member))
                    return false;
            }

            return true;
        }

        private bool IsValidLine(int[] line)
        {
            var validator = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            return line.OrderBy(d => d).SequenceEqual(validator);
        }
    }
}
