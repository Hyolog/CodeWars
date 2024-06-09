using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5616868c81a0f281e500005c/train/csharp"/>
    [TestClass]
    public class PrizeDraw
    {
        [TestMethod]
        public void Test()
        {
            string st = "";
            int[] we = new int[] { 4, 2, 1, 4, 3, 1, 2 };
            Assert.AreEqual("No participants", NthRank(st, we, 4));

            st = "COLIN,AMANDBA,AMANDAB,CAROL,PauL,JOSEPH";
            we = new int[] { 1, 4, 4, 5, 2, 1 };
            Assert.AreEqual("PauL", NthRank(st, we, 4));

            st = "addison,jayden,sofia,michael,andrew,lily,benjamin";
            we = new int[] { 4, 2, 1, 4, 3, 1, 2 };
            Assert.AreEqual("Not enough participants", NthRank(st, we, 8));

            st = "Addison,Jayden,Sofia,Michael,Andrew,Lily,Benjamin";
            we = new int[] { 4, 2, 1, 4, 3, 1, 2 };
            Assert.AreEqual("Benjamin", NthRank(st, we, 4));

            st = "Elijah,Chloe,Elizabeth,Matthew,Natalie,Jayden";
            we = new int[] { 1, 3, 5, 5, 3, 6 };
            Assert.AreEqual("Matthew", NthRank(st, we, 2));
        }

        // st : 이름 배열
        // we : 가중치
        // n : result index
        public static string NthRank(string st, int[] we, int n)
        {
            if (string.IsNullOrEmpty(st))
            {
                return "No participants";
            }

            string[] names = st.Split(',');
            if (n > names.Length)
            {
                return "Not enough participants";
            }

            var nameScores = names.Select((name, index) =>
            {
                int som = name.Length + name.ToUpper().Sum(c => c - 'A' + 1);
                int winningNumber = som * we[index];
                return new { Name = name, WinningNumber = winningNumber };
            });

            var sortedNames = nameScores.OrderByDescending(nm => nm.WinningNumber)
                                        .ThenBy(nm => nm.Name)
                                        .Select(nm => nm.Name)
                                        .ToList();

            return sortedNames[n - 1];
        }
    }
}
