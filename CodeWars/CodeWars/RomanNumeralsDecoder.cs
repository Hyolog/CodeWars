using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/51b6249c4612257ac0000005/train/javascript"/>
    [TestClass]
    public class RomanNumeralsDecoder
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(1, Solution("I"));
            Assert.AreEqual(21, Solution("XXI"));
            Assert.AreEqual(1990, Solution("MCMXC"));
            Assert.AreEqual(2008, Solution("MMVIII"));
            Assert.AreEqual(1666, Solution("MDCLXVI"));
        }

        public int Solution(string roman)
        {
            var symbols = new Dictionary<char, int>() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };

            var result = 0;
            var temporaryValue = 0;

            foreach (var item in roman)
            {
                symbols.TryGetValue(item, out var value);

                if (value > temporaryValue)
                    value -= temporaryValue * 2;

                temporaryValue = value;
                result += value;
            }

            return result;
        }
    }
}
