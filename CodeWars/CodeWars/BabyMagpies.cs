using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59bb02f5623654a0dc000119/train/csharp"/>
    [TestClass]
    public class BabyMagpies
    {
        private string m1 = "BWBWBW";
        private string m2 = "BWBWBB";
        private string m3 = "WWWWBB";

        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(true, Child(m1, m2));
            Assert.AreEqual(true, Child(m2, m3));
            Assert.AreEqual(true, Grandchild(m1, m3));
            Assert.AreEqual(true, Grandchild(m1, m2));
            Assert.AreEqual(false, Child(m1, m3));

            m1 = "BWWBWBBWB";
            m2 = "WWWWBWBWW";
            Assert.AreEqual(false, Grandchild(m1, m2));

            m1 = "BWWWWWWWB";
            m2 = "BWBBBBBWB";
            Assert.AreEqual(false, Grandchild(m1, m2));

            m1 = "W";
            m2 = "B";
            Assert.AreEqual(true, Child(m1, m2));
            Assert.AreEqual(false, Grandchild(m1, m2));
        }

        public static bool Child(string bird1, string bird2)
        {
            var diffCount = GetDiffItemsCount(bird1, bird2);

            return (diffCount >= 1 && diffCount <= 2) ? true : false;
        }

        public static bool Grandchild(string bird1, string bird2)
        {
            var diffCount = GetDiffItemsCount(bird1, bird2);

            // ³õÃÆ´ø ºÎºÐ
            if (bird1.Length == 1 && bird1[0] != bird2[0])
                return false;

            return (diffCount >= 0 && diffCount <= 4) ? true : false;
        }

        public static int GetDiffItemsCount(string bird1, string bird2)
        {
            var result = 0;

            for (int i = 0; i < bird1.Length; i++)
            {
                if (bird1[i] != bird2[i])
                    result++;
            }

            return result;
        }
    }
}
