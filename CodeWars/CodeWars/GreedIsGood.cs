using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5270d0d18625160ada0000e4/train/csharp"/>
    [TestClass]
    public class GreedIsGood
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(0, Score(new int[] { 2, 3, 4, 6, 2 }), "Should be 0 :-(");
            Assert.AreEqual(400, Score(new int[] { 4, 4, 4, 3, 3 }), "Should be 400");
            Assert.AreEqual(450, Score(new int[] { 2, 4, 4, 5, 4 }), "Should be 450");
            Assert.AreEqual(1100, Score(new int[] { 1, 1, 1, 1, 3 }), "Should be 1100");
        }


        public class DiceHistory
        {
            public int CountOf1 { get; set; }
            public int CountOf2 { get; set; }
            public int CountOf3 { get; set; }
            public int CountOf4 { get; set; }
            public int CountOf5 { get; set; }
            public int CountOf6 { get; set; }

            public void Record(int value)
            {
                switch (value)
                {
                    case 1: CountOf1++; break;
                    case 2: CountOf2++; break;
                    case 3: CountOf3++; break;
                    case 4: CountOf4++; break;
                    case 5: CountOf5++; break;
                    case 6: CountOf6++; break;
                    default: break;
                }
            }

            public int CalculateScore()
            {
                var score = 0;

                score += (CountOf1 / 3) * 1000;
                score += (CountOf2 / 3) * 200;
                score += (CountOf3 / 3) * 300;
                score += (CountOf4 / 3) * 400;
                score += (CountOf5 / 3) * 500;
                score += (CountOf6 / 3) * 600;

                score += (CountOf1 % 3) * 100;
                score += (CountOf5 % 3) * 50;

                return score;
            }
        }

        public int Score(int[] dice)
        {
            var diceHistory = new DiceHistory();

            foreach (var item in dice)
                diceHistory.Record(item);

            return diceHistory.CalculateScore();
        }
    }
}
