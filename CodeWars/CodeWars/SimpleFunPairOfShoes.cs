using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/58885a7bf06a3d466e0000e3/train/csharp"/>
    [TestClass]
    public class SimpleFunPairOfShoes
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(true, PairOfShoes(new int[][] { new int[] { 0, 21 }, new int[] { 1, 23 }, new int[] { 1, 21 }, new int[] { 0, 23 } }));
            Assert.AreEqual(false, PairOfShoes(new int[][] { new int[] { 0, 21 }, new int[] { 1, 23 }, new int[] { 1, 21 }, new int[] { 1, 23 } }));
            Assert.AreEqual(true, PairOfShoes(new int[][] { new int[] { 0, 23 }, new int[] { 1, 21 }, new int[] { 1, 23 }, new int[] { 0, 21 }, new int[] { 1, 22 }, new int[] { 0, 22 } }));
            Assert.AreEqual(true, PairOfShoes(new int[][] { new int[] { 0, 23 }, new int[] { 1, 21 }, new int[] { 1, 23 }, new int[] { 0, 21 } }));
            Assert.AreEqual(false, PairOfShoes(new int[][] { new int[] { 0, 23 } }));
            Assert.AreEqual(true, PairOfShoes(new int[][] { new int[] { 0, 23 }, new int[] { 1, 23 } }));
            Assert.AreEqual(false, PairOfShoes(new int[][] { new int[] { 0, 23 }, new int[] { 1, 22 } }));
        }

        public bool PairOfShoes(int[][] shoes)
        {
            var groups = shoes.GroupBy(d => d[1]);

            foreach (var group in groups)
            {
                var count = group.Count();
                var leftCount = group.Count(d => d[0] == 0);

                if (leftCount * 2 != count)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
