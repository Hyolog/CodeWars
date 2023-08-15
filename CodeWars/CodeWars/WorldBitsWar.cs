using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/58865bfb41e04464240000b0/train/csharp"/>
    [TestClass]
    public class WorldBitsWar
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(BitsWar(new List<int> { 1, 5, 12 }), "odds win");
            Assert.AreEqual(BitsWar(new List<int> { 7, -3, 20 }), "evens win");
            Assert.AreEqual(BitsWar(new List<int> { 7, -3, -2, 6 }), "tie");
            Assert.AreEqual(BitsWar(new List<int> { -3, -5 }), "evens win");
            Assert.AreEqual(BitsWar(new List<int>()), "tie");
        }

        public static string BitsWar(List<int> numbers)
        {
            int oddsScore = 0;
            int evensScore = 0;

            foreach (int number in numbers)
            {
                int strength = CountSetBits(Math.Abs(number)); // Always get positive strength first
                if (number < 0)
                    strength = -strength; // If number is negative, negate the strength

                if (number % 2 == 0)
                    evensScore += strength;
                else
                    oddsScore += strength;
            }

            if (oddsScore > evensScore) return "odds win";
            else if (oddsScore < evensScore) return "evens win";
            else return "tie";
        }

        private static int CountSetBits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n & 1;
                n >>= 1;
            }
            return count;
        }
    }
}
