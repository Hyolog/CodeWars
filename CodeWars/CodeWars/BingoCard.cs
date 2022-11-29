using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/566d5e2e57d8fae53c00000c/train/csharp"/>
    [TestClass]
    public class BingoCard
    {
        [TestMethod]
        public void NumbersAreOrderedByColumn()
        {
            var columns = string.Join("", BingoCard.GetCard().ToList()
                .Select(x => x.Substring(0, 1)).ToArray());

            Assert.IsTrue(Regex.IsMatch(columns, "^[B]*[I]*[N]*[G]*[O]*$"));
        }

        [TestMethod]
        public void NumbersWithinColumnAreInRandomOrder()
        {
            var card = BingoCard.GetCard().Select(x => Convert.ToInt32(x.Substring(1))).ToArray();

            var isRandom = false;
            for (var i = 1; i < card.Length; i++)
            {
                if (card[i - 1] > card[i])
                {
                    isRandom = true;
                    break;
                }
            }

            Assert.IsTrue(isRandom, "Unlikely result, is the list ordered?");
        }

        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(24, BingoCard.GetCard().Length);

            var card = BingoCard.GetCard();
            Assert.AreEqual(card.Length, card.ToList().Distinct().Count());
        }

        public static string[] GetCard()
        {
            var result = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                var b = new Random().Next(1, 16);

                if (result.Contains($"B{b}"))
                {
                    i--;
                    continue;
                }

                result.Add($"B{b}");
            }

            for (int j = 0; j < 5; j++)
            {
                var i = new Random().Next(16, 31);

                if (result.Contains($"I{i}"))
                {
                    j--;
                    continue;
                }

                result.Add($"I{i}");
            }

            for (int i = 0; i < 4; i++)
            {
                var n = new Random().Next(31, 46);

                if (result.Contains($"N{n}"))
                {
                    i--;
                    continue;
                }

                result.Add($"N{n}");
            }

            for (int i = 0; i < 5; i++)
            {
                var g = new Random().Next(46, 61);

                if (result.Contains($"G{g}"))
                {
                    i--;
                    continue;
                }

                result.Add($"G{g}");
            }

            for (int i = 0; i < 5; i++)
            {
                var o = new Random().Next(61, 76);

                if (result.Contains($"O{o}"))
                {
                    i--;
                    continue;
                }

                result.Add($"O{o}");
            }

            return result.ToArray();
        }
    }
}
