using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/586eca3b35396db82e000481/train/csharp"/>
    [TestClass]
    public class GetEuchreScore
    {
        [TestMethod]
        public void Test()
        {
            var score = new int[] { 0, 0 };

            // Starting score is 0 - 0. Team 1 calls trump (does not go alone) and wins 5 tricks
            score = UpdateScore(score, 1, false, new int[] { 1, 1, 1, 1, 1 });
            Assert.AreEqual(2, score[0]);
            Assert.AreEqual(0, score[1]);

            // New score is 2 - 0. Team 2 calls trump (does not go alone) and wins 4 tricks
            score = UpdateScore(score, 2, false, new int[] { 2, 2, 2, 2, 1 });
            Assert.AreEqual(2, score[0]);
            Assert.AreEqual(1, score[1]);

            // New score is 2 - 1. Team 1 calls trump (does not go alone) and wins 3 tricks
            score = UpdateScore(score, 1, false, new int[] { 1, 2, 1, 2, 1 });
            Assert.AreEqual(3, score[0]);
            Assert.AreEqual(1, score[1]);

            // New score is 3 - 1. Team 2 calls trump (goes alone) and wins 5 tricks
            score = UpdateScore(score, 2, true, new int[] { 2, 2, 2, 2, 2 });
            Assert.AreEqual(3, score[0]);
            Assert.AreEqual(5, score[1]);

            // New score is 3 - 5. Team 1 calls trump (goes alone) and wins 2 tricks
            score = UpdateScore(score, 1, true, new int[] { 2, 1, 2, 2, 1 });
            Assert.AreEqual(3, score[0]);
            Assert.AreEqual(7, score[1]);
        }

        public int[] UpdateScore(int[] currentScore, int calledTrump, bool alone, int[] tricks)
        {
            int team1Score = currentScore[0];
            int team2Score = currentScore[1];

            int winningTeam = tricks.Count(t => t == calledTrump) > 2 ? calledTrump : (calledTrump == 1 ? 2 : 1);

            int winningTeamPoints = CalculateWinningTeamPoints(tricks, calledTrump, alone, winningTeam);

            if (winningTeam == 1)
            {
                team1Score += winningTeamPoints;
            }
            else
            {
                team2Score += winningTeamPoints;
            }

            return new int[] { team1Score, team2Score };
        }

        private static int CalculateWinningTeamPoints(int[] tricks, int calledTrump, bool alone, int winningTeam)
        {
            int tricksWon = tricks.Count(t => t == winningTeam);

            if (winningTeam == calledTrump)
            {
                if (tricksWon <= 2)
                {
                    return 0;
                }
                else if (tricksWon == 3 || tricksWon == 4)
                {
                    return 1;
                }
                else if (!alone)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
            else
            {
                return 2;
            }
        }
    }
}
