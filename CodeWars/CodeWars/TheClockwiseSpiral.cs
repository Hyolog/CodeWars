using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/536a155256eb459b8700077e/train/csharp"/>
    [TestClass]
    public class TheClockwiseSpiral
    {
        [TestMethod]
        public void Test()
        {
            var expected = new int[,] { { 1 } };
            CollectionAssert.AreEqual(expected, TheClockwiseSpiral.CreateSpiral(1));

            expected = new int[,]
            {
                {1, 2},
                {4, 3},
            };
            CollectionAssert.AreEqual(expected, TheClockwiseSpiral.CreateSpiral(2));

            expected = new int[,]
            {
                {1, 2, 3},
                {8, 9, 4},
                {7, 6, 5}
            };
            CollectionAssert.AreEqual(expected, TheClockwiseSpiral.CreateSpiral(3));

            expected = new int[,]
            {
                {1, 2, 3, 4, 5},
                {16, 17, 18, 19, 6},
                {15, 24, 25, 20, 7},
                {14, 23, 22, 21, 8},
                {13, 12, 11, 10, 9},
            };
            CollectionAssert.AreEqual(expected, TheClockwiseSpiral.CreateSpiral(5));
        }

        public static int[,] CreateSpiral(int N)
        {
            var result = new int[N, N];
            var directions = new string[4] { "column+", "row+", "column-", "row-" };
            var dirIndex = 0;
            var row = 0;
            var column = 0;

            for (int i = 0; i < N * N; i++)
            {
                result[row, column] = i + 1;

                switch (directions[dirIndex])
                {
                    case "column+":
                        {
                            if (column < N - 1 && result[row, column + 1] == 0)
                            {
                                column++;
                            }
                            else
                            {
                                dirIndex++;
                                row++;
                            }
                        } break;
                    case "row+":
                        {
                            if (row < N - 1 && result[row + 1, column] == 0)
                            {
                                row++;
                            }
                            else
                            {
                                dirIndex++;
                                column--;
                            }
                        } break;
                    case "column-":
                        {
                            if (column > 0 && result[row, column - 1] == 0)
                            {
                                column--;
                            }
                            else
                            {
                                dirIndex++;
                                row--;
                            }
                        } break;
                    case "row-":
                        {
                            if (row > 0 && result[row- 1, column] == 0)
                            {
                                row--;
                            }
                            else
                            {
                                dirIndex = 0;
                                column++;
                            }
                        } break;
                    default: break;
                }
            }

            return result;
        }
    }
}
