using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/521c2db8ddc89b9b7a0000c1"/>
    /// TODO : DP로 다시 풀어보기
    [TestClass]
    public class Snail
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 }, SnailFunc(new int[][] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }));
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 }, SnailFunc(new int[][] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 9, 10, 11, 12 } }));
            CollectionAssert.AreEqual(new int[] { }, SnailFunc(new int[][] { }));
            CollectionAssert.AreEqual(new[] { 1 }, SnailFunc(new int[][] { new[] { 1 } }));
            CollectionAssert.AreEqual(new int[] { }, SnailFunc(new int[][] { new int[] { } }));
        }

        public enum Direction
        {
            Right,
            Down,
            Left,
            Up
        }

        private static int[] SnailFunc(int[][] array)
        {
            if (array == null || array.Length == 0 || array[0].Length == 0)
                return new int[] { };

            var map = array;
            var visited = new bool[array.GetLength(0), array[0].Length];
            var currentDirection = Direction.Right; 
            int currentX = 0;
            int currentY = 0; 
            var history = new List<int>();
            int moveCount = 1;

            visited[0, 0] = true;
            history.Add(map[0][0]);

            while (moveCount < (array[0].Length * array.Length))
            {
                switch (currentDirection)
                {
                    case Direction.Right:
                        {
                            var maxX = visited.GetLength(1) - 1;

                            if (currentX < maxX && visited[currentY, currentX + 1] == false)
                            {
                                currentX++;
                                visited[currentY, currentX] = true;
                                history.Add(map[currentY][currentX]);
                                moveCount++;
                            }
                            else
                                currentDirection = Direction.Down;
                        }
                        break;
                    case Direction.Down:
                        {
                            var maxY = visited.GetLength(0) - 1;

                            if (currentY < maxY && visited[currentY + 1, currentX] == false)
                            {
                                currentY++;
                                visited[currentY, currentX] = true;
                                history.Add(map[currentY][currentX]);
                                moveCount++;
                            }
                            else
                                currentDirection = Direction.Left;
                        }
                        break;
                    case Direction.Left:
                        {
                            if (currentX > 0 && visited[currentY, currentX - 1] == false)
                            {
                                currentX--;
                                visited[currentY, currentX] = true;
                                history.Add(map[currentY][currentX]);
                                moveCount++;
                            }
                            else
                                currentDirection = Direction.Up;
                        }
                        break;
                    case Direction.Up:
                        {
                            if (currentY > 0 && visited[currentY - 1, currentX] == false)
                            {
                                currentY--;
                                visited[currentY, currentX] = true;
                                history.Add(map[currentY][currentX]);
                                moveCount++;
                            }
                            else
                                currentDirection = Direction.Right;
                        }
                        break;
                    default: break;
                }
            }

            return history.ToArray();
        }
    }
}
