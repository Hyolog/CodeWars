using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/590adadea658017d90000039/train/csharp"/>
    [TestClass]
    public class FruitMachine
    {
        [TestMethod]
        public void Test()
        {
            string[] reel = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel, reel, reel };
            int[] spins = new int[] { 0, 0, 0 };
            Assert.AreEqual(100, Fruit(reels, spins));

            string[] reel1 = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            string[] reel2 = new string[] { "Bar", "Wild", "Queen", "Bell", "King", "Seven", "Cherry", "Jack", "Star", "Shell" };
            string[] reel3 = new string[] { "Bell", "King", "Wild", "Bar", "Seven", "Jack", "Shell", "Cherry", "Queen", "Star" };
            reels = new List<string[]> { reel1, reel2, reel3 };
            spins = new int[] { 5, 4, 3 };
            Assert.AreEqual(0, Fruit(reels, spins));

            reel1 = new string[] { "King", "Cherry", "Bar", "Jack", "Seven", "Queen", "Star", "Shell", "Bell", "Wild" };
            reel2 = new string[] { "Bell", "Seven", "Jack", "Queen", "Bar", "Star", "Shell", "Wild", "Cherry", "King" };
            reel3 = new string[] { "Wild", "King", "Queen", "Seven", "Star", "Bar", "Shell", "Cherry", "Jack", "Bell" };
            reels = new List<string[]> { reel1, reel2, reel3 };
            spins = new int[] { 0, 0, 1 };
            Assert.AreEqual(3, Fruit(reels, spins));
        }

        public int Fruit(List<string[]> reels, int[] spins)
        {
            var score = new Dictionary<string, int>()
            {
                { "Wild", 10 },
                { "Star", 9 },
                { "Bell", 8 },
                { "Shell", 7 },
                { "Seven", 6 },
                { "Cherry", 5 },
                { "Bar", 4 },
                { "King", 3 },
                { "Queen", 2 },
                { "Jack", 1 }
            };

            var val1 = reels[0][spins[0]];
            var val2 = reels[1][spins[1]];
            var val3 = reels[2][spins[2]];

            if (val1 == val2 && val2 == val3)
            {
                if (score.TryGetValue(val1, out var val))
                {
                    return val * 10;
                }
            }
            else if (val1 == val2)
            {
                if (score.TryGetValue(val1, out var val))
                {
                    return val3 == "Wild" ? val * 2 : val;
                }
            }
            else if (val2 == val3)
            {
                if (score.TryGetValue(val2, out var val))
                {
                    return val1 == "Wild" ? val * 2 : val;
                }
            }
            else if (val3 == val1)
            {
                if (score.TryGetValue(val3, out var val))
                {
                    return val2 == "Wild" ? val * 2 : val;
                }
            }

            return 0;
        }
    }
}
