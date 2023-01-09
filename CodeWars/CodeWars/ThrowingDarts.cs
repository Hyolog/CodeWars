using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/525dfedb5b62f6954d000006/train/csharp"/>
    [TestClass]
    public class ThrowingDarts
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(15, ScoreThrows(new double[] { 1, 5, 11 }));
            Assert.AreEqual(30, ScoreThrows(new double[] { 0.0d, 5.0d, 10.0d, 10.5d, 4.5d, 100 }));
            Assert.AreEqual(0, ScoreThrows(new double[] { }));
            Assert.AreEqual(30, ScoreThrows(new double[] { 0, 5, 10, 10.5, 4.5 }));
        }

        public static int ScoreThrows(double[] radii)
        {
            var score = 0;

            foreach (var item in radii)
            {
                if (item >= 5 && item <= 10)
                    score += 5;
                else if (item < 5)
                    score += 10;
            }

            if (radii.Length != 0 && score == radii.Length * 10)
                score += 100;

            return score;
        }
    }
}
