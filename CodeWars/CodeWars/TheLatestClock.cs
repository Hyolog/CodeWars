using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/58925dcb71f43f30cd00005f/train/csharp"/>
    [TestClass]
    public class TheLatestClock
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("19:28", LatestClock(1, 2, 8, 9), "Kata.LatestClock(9, 1, 2, 5) should return '21:59'.");
            Assert.AreEqual("19:38", LatestClock(1, 9, 8, 3), "Kata.LatestClock(1, 9, 8, 3) should return '19:38'.");
            Assert.AreEqual("21:59", LatestClock(9, 1, 2, 5), "Kata.LatestClock(9, 1, 2, 5) should return '21:59'.");
        }

        public static string LatestClock(int a, int b, int c, int d)
        {
            var list = new List<int>() { a, b, c, d };

            var first = list.Where(d => d <= 2).Max();
            list.Remove(first);

            int second;

            if (first == 2)
            {
                second = list.Where(d => d <= 3).Max();
                list.Remove(second);

                if (list.Count(d => d <= 5) == 0)
                {
                    list.Add(first);
                    list.Add(second);

                    first = list.Where(d => d <= 1).Max();
                    list.Remove(first);

                    second = list.Max();
                    list.Remove(second);
                }
            }
            else
            {
                second = list.Max();
                list.Remove(second);
            }

            var third = list.Where(d => d <= 5).Max();
            list.Remove((int)third);

            var fourth = list[0];

            return $"{first}{second}:{third}{fourth}";
        }
    }
}
