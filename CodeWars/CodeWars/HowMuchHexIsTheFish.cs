using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5714eb80e1bf814e53000c06/train/csharp"/>
    [TestClass]
    public class HowMuchHexIsTheFish
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(1, FisHex("pufferfish"));
            Assert.AreEqual(14, FisHex("puffers"));
            Assert.AreEqual(14, FisHex("balloonfish"));
            Assert.AreEqual(4, FisHex("blowfish"));
            Assert.AreEqual(10, FisHex("bubblefish"));
            Assert.AreEqual(10, FisHex("globefish"));
            Assert.AreEqual(1, FisHex("swellfish"));
            Assert.AreEqual(8, FisHex("toadfish"));
            Assert.AreEqual(9, FisHex("toadies"));
            Assert.AreEqual(9, FisHex("honey toads"));
            Assert.AreEqual(13, FisHex("sugar toads"));
            Assert.AreEqual(5, FisHex("sea squab"));
            Assert.AreEqual(5, FisHex("sea squab"));
            Assert.AreEqual(1, FisHex("Aeneus corydoras"));
        }

        public static int FisHex(string name)
        {
            Console.WriteLine(name);

            var matches = Regex.Matches(name, "[a-fA-F]");

            if (matches.Count == 0)
            {
                return 0;
            }

            int result = 0;

            foreach (Match match in matches)
            {
                int hexValue = Convert.ToInt32(match.Value, 16);
                result ^= hexValue;
            }

            return result;
        }
    }
}
