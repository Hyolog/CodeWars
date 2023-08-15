using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/545f05676b42a0a195000d95/train/csharp"/>
    [TestClass]
    public class RankVector
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(Ranks(new int[0]), new int[0]);
            CollectionAssert.AreEqual(Ranks(new int[] { 2 }), new int[] { 1 });
            CollectionAssert.AreEqual(Ranks(new int[] { 2, 2 }), new int[] { 1, 1 });
            CollectionAssert.AreEqual(Ranks(new int[] { 1, 2, 3 }), new int[] { 3, 2, 1 });
            CollectionAssert.AreEqual(Ranks(new int[] { -5, -10, 3, 1 }), new int[] { 3, 4, 1, 2 });
            CollectionAssert.AreEqual(Ranks(new int[] { -1, 3, 3, 3, 5, 5 }), new int[] { 6, 3, 3, 3, 1, 1 });
            CollectionAssert.AreEqual(Ranks(new int[] { 1, 10, 4 }), new int[] { 3, 1, 2 });
            CollectionAssert.AreEqual(Ranks(new int[] { 5, 2, 3, 5, 5, 4, 9, 8, 0 }), new int[] { 3, 8, 7, 3, 3, 6, 1, 2, 9 });
        }

        public static int[] Ranks(int[] scores)
        {
            var orderedScores = scores.OrderByDescending(s => s).ToList();
            int[] ranks = new int[scores.Length];

            for (int i = 0; i < scores.Length; i++)
            {
                ranks[i] = orderedScores.IndexOf(scores[i]) + 1;
                while (i + 1 < scores.Length && scores[i] == scores[i + 1])
                {
                    ranks[i + 1] = ranks[i];
                    i++;
                }
            }

            return ranks;
        }
    }
}
