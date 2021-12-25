using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/52de553ebb55d1fca3000371/train/csharp"/>
    [TestClass]
    public class FindTheMissingTermInAnArithmeticProgression
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(FindMissing(new List<int> { 1, 3, 5, 9, 11 }), 7);
            Assert.AreEqual(FindMissing(new List<int> { 0, 5, 10, 20, 25 }), 15);
            Assert.AreEqual(FindMissing(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 }), 10);
            Assert.AreEqual(FindMissing(new List<int> { 1040, 1220, 1580 }), 1400);
            Assert.AreEqual(FindMissing(new List<int> { -3, -1, 3, 5, 7 }), 1);
            Assert.AreEqual(FindMissing(new List<int> { -10, -5, 0, 10, 15, 20 }), 5);
        }

        public int FindMissing(List<int> list)
        {
            int diff = (list.Last() - list.First()) / list.Count();
            int current = list.First();

            for (int i = 0; i < list.Count(); ++i)
            {
                if (list[i] != current) 
                    return current; 
                
                current += diff;
            }

            return 0;
        }
    }
}
