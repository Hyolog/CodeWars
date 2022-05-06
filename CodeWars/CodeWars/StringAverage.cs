using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5966847f4025872c7d00015b/train/csharp"/>
    /// TODO : Linq로 다시 풀어보기
    [TestClass]
    public class StringAverage
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("four", AverageString("zero nine five two"));
            Assert.AreEqual("three", AverageString("four six two three"));
            Assert.AreEqual("three", AverageString("one two three four five"));
            Assert.AreEqual("four", AverageString("five four"));
            Assert.AreEqual("zero", AverageString("zero zero zero zero zero"));
            Assert.AreEqual("two", AverageString("one one eight one"));
            Assert.AreEqual("n/a", AverageString(""));
        }

        public static string AverageString(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return "n/a";

            var sum = 0;
            var numbers = str.Split(' ');

            var numberStringSet = new Dictionary<string, int>()
            {
                { "zero", 0 }, { "one", 1 }, { "two", 2 }, { "three", 3 }, { "four", 4 }, { "five", 5 }, { "six", 6 }, { "seven", 7 }, { "eight", 8 }, { "nine", 9 }
            };

            foreach (var numberString in numbers)
            {
                if (numberStringSet.TryGetValue(numberString, out var number))
                    sum += number;
                else
                    return "n/a";
            }

            int average = sum / numbers.Length;

            return numberStringSet.First(d => d.Value == average).Key;
        }
    }
}
