using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/57eb8fcdf670e99d9b000272"/>
    [TestClass]
    public class HighestScoringWord
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("aaa", High("aaa b"));
            Assert.AreEqual("aa", High("aa b"));
            Assert.AreEqual("b", High("b aa"));
            Assert.AreEqual("bb", High("bb d"));
            Assert.AreEqual("d", High("d bb"));
        }

        public string High(string s)
        {
            var highScoreWordIndex = -1;
            var highScore = -1;

            var words = s.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                var score = GetScore(words[i]);

                if (score > highScore)
                {
                    highScoreWordIndex = i;
                    highScore = score;
                }
            }

            return words[highScoreWordIndex];
        }

        private int GetScore(string word)
        {
            var score = 0;
            
            foreach (var item in word)
                score += (item - 96);

            return score;
        }
    }
}
