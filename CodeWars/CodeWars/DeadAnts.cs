using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/57d5e850bfcdc545870000b7/train/csharp"/>
    [TestClass]
    public class DeadAnts
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(0, DeadAntCount("ant ant ant ant"));
            Assert.AreEqual(0, DeadAntCount(null));
            Assert.AreEqual(2, DeadAntCount("ant anantt aantnt"));
            Assert.AreEqual(1, DeadAntCount("ant ant .... a nt"));
        }

        public static int DeadAntCount(string ants)
        {
            if (string.IsNullOrWhiteSpace(ants))
                return 0;

            var splited = ants.Replace("ant", "");
            var countOfA = splited.Count(d => d.Equals('a'));
            var countOfN = splited.Count(d => d.Equals('n'));
            var countOfT = splited.Count(d => d.Equals('t'));

            return Math.Max(Math.Max(countOfA, countOfN), countOfT);
        }
    }
}
