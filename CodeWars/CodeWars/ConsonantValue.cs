using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59c633e7dcc4053512000073/train/csharp"/>
    /// TODO : Linq로 다시 풀어보기
    [TestClass]
    public class ConsonantValue
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(Solve("cjewkggvudsbioumkzqtcspq"), 142);
            Assert.AreEqual(Solve("zodiac"), 26);
            Assert.AreEqual(Solve("chruschtschov"), 80);
            Assert.AreEqual(Solve("khrushchev"), 38);
            Assert.AreEqual(Solve("strength"), 57);
            Assert.AreEqual(Solve("catchphrase"), 73);
            Assert.AreEqual(Solve("twelfthstreet"), 103);
            Assert.AreEqual(Solve("mischtschenkoana"), 80);
        }

        public static int Solve(string s)
        {
            s += 'a';

            var result = 0;
            var tempResult = 0;

            foreach (var item in s)
            {
                if (IsVowel(item))
                {
                    result = Math.Max(result, tempResult);
                    tempResult = 0;
                }
                else
                    tempResult += (item - 96);
            }

            return result;
        }

        private static bool IsVowel(char character)
        {
            return character.Equals('a') || character.Equals('e') || character.Equals('i') || character.Equals('o') || character.Equals('u');
        }

        //public static int Solve(string s)
        //{
        //    return s.Split('a', 'e', 'i', 'o', 'u').Max(x => x.Sum(c => c - 96));
        //}
    }
}
