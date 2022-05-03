using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/586d6cefbcc21eed7a001155/train/csharp"/>
    [TestClass]
    public class CharacterWithLongestConsecutiveRepetition
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(new Tuple<char?, int>('a', 4), LongestRepetition("aaaabb"));
            Assert.AreEqual(new Tuple<char?, int>('b', 5), LongestRepetition("abbbbb"));
            Assert.AreEqual(new Tuple<char?, int>('a', 4), LongestRepetition("bbbaaabaaaa"));
            Assert.AreEqual(new Tuple<char?, int>('u', 3), LongestRepetition("cbdeuuu900"));
            Assert.AreEqual(new Tuple<char?, int>('a', 2), LongestRepetition("aabb"));
            Assert.AreEqual(new Tuple<char?, int>('b', 1), LongestRepetition("ba"));
            Assert.AreEqual(new Tuple<char?, int>(null, 0), LongestRepetition(""));
        }

        public static Tuple<char?, int> LongestRepetition(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return new Tuple<char?, int>(null, 0);

            char resultChar = input[0];
            int resultCount = 1;

            char pivotChar = input[0];
            int pivotCount = 1;

            for (var index = 1; index < input.Length; index++)
            {
                if (pivotChar.Equals(input[index]))
                    pivotCount++;
                else
                {
                    pivotChar = input[index];
                    pivotCount = 1;
                }

                if (resultCount < pivotCount)
                {
                    resultChar = pivotChar;
                    resultCount = pivotCount;
                }
            }

            return new Tuple<char?, int>(resultChar, resultCount);
        }
    }
}
