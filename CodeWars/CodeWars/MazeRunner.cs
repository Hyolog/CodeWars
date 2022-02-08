using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/58663693b359c4a6560001d6/train/csharp"/>
    [TestClass]
    public class MazeRunner
    {
        private int[,] maze = new int[,] { { 1, 1, 1, 1, 1, 1, 1 },
                                           { 1, 0, 0, 0, 0, 0, 3 },
                                           { 1, 0, 1, 0, 1, 0, 1 },
                                           { 0, 0, 1, 0, 0, 0, 1 },
                                           { 1, 0, 1, 0, 1, 0, 1 },
                                           { 1, 0, 0, 0, 0, 0, 1 },
                                           { 1, 2, 1, 0, 1, 0, 1 } };

        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("Dead", mazeRunner(maze, new string[] { "N", "N", "N", "W", "W" }));
            Assert.AreEqual("Dead", mazeRunner(maze, new string[] { "N", "N", "N", "N", "N", "E", "E", "S", "S", "S", "S", "S", "S" }));
            Assert.AreEqual("Lost", mazeRunner(maze, new string[] { "N", "E", "E", "E", "E" }));
            Assert.AreEqual("Finish", mazeRunner(maze, new string[] { "N", "N", "N", "N", "N", "E", "E", "E", "E", "E" }));
            Assert.AreEqual("Finish", mazeRunner(maze, new string[] { "N", "N", "N", "N", "N", "E", "E", "S", "S", "E", "E", "N", "N", "E" }));
            Assert.AreEqual("Finish", mazeRunner(maze, new string[] { "N", "N", "N", "N", "N", "E", "E", "E", "E", "E", "W", "W" }));
        }

        public string mazeRunner(int[,] maze, string[] directions)
        {
            var pointX = 0;
            var pointY = 0;

            for (int y = 0; y < maze.GetLength(0); y++)
            {
                for (int x = 0; x < maze.GetLength(1); x++)
                {
                    if (maze[y, x].Equals(2))
                    {
                        pointX = x;
                        pointY = y;
                    }
                }
            }

            foreach (var direction in directions)
            {
                switch (direction)
                {
                    case "E": pointX++; break;
                    case "W": pointX--; break;
                    case "S": pointY++; break;
                    case "N": pointY--; break;
                    default: break;
                }

                try
                {
                    var key = maze[pointY, pointX];

                    if (key.Equals(1))
                        return "Dead";
                    else if (key.Equals(3))
                        return "Finish";
                }
                catch
                {
                    return "Dead";
                }
            }

            return "Lost";
        }
    }
}
