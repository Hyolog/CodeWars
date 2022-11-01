using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/58068479c27998b11900056e/train/csharp"/>
    /// Todo : 다시 풀어보기 (hint : .OrderBy(d => {return ..}).ToArray();
    [TestClass]
    public class SortingOnPlanetTwisted37
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(string.Join(",", new[] { 1, 2, 7, 4, 5, 6, 3, 8, 9 }), string.Join(",", SortTwisted37(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })));
            Assert.AreEqual(string.Join(",", new[] { 12, 14, 13 }), string.Join(",", SortTwisted37(new[] { 12, 13, 14 })));
            Assert.AreEqual(string.Join(",", new[] { 2, 7, 4, 3, 9 }), string.Join(",", SortTwisted37(new[] { 9, 2, 4, 7, 3 })));
        }

        public static int[] SortTwisted37(int[] array)
        {
            var tempResult = new List<KeyValuePair<int, int>>();

            foreach (var num in array)
            {
                var numCharArray = num.ToString().ToCharArray();
                char[] numCharArrayCopy = new char[numCharArray.Length];
                numCharArray.CopyTo(numCharArrayCopy, 0);

                for (int i = 0; i < numCharArray.Length; i++)
                {
                    if (numCharArray[i].Equals('3'))
                        numCharArray[i] = '7';
                    else if (numCharArray[i].Equals('7'))
                        numCharArray[i] = '3';
                }

                tempResult.Add(new KeyValuePair<int, int>(int.Parse(numCharArray), int.Parse(numCharArrayCopy)));
            }

            return tempResult.OrderBy(d => d.Key).Select(d => d.Value).ToArray();
        }
    }
}
