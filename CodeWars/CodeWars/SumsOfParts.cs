using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5ce399e0047a45001c853c2b/train/csharp"/>
    [TestClass]
    public class SumsOfParts
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(PartsSums(new int[] { }), new int[] { 0 });
            CollectionAssert.AreEqual(PartsSums(new int[] { 0, 1, 3, 6, 10 }), new int[] { 20, 20, 19, 16, 10, 0 });
            CollectionAssert.AreEqual(PartsSums(new int[] { 1, 2, 3, 4, 5, 6 }), new int[] { 21, 20, 18, 15, 11, 6, 0 });
            CollectionAssert.AreEqual(PartsSums(new int[] { 744125, 935, 407, 454, 430, 90, 144, 6710213, 889, 810, 2579358 }), new int[] { 10037855, 9293730, 9292795, 9292388, 9291934, 9291504, 9291414, 9291270, 2581057, 2580168, 2579358, 0 });
        }

        public int[] PartsSums(int[] ls)
        {
            if (ls.Length == 0)
                return new int[] { 0 };

            var sum = ls.Sum();
            var result = new int[ls.Length + 1];
            result[0] = sum;

            for (int i = 0; i < ls.Length; i++)
            {
                result[i + 1] = sum - ls[i];
                sum -= ls[i];
            }

            return result;
        }
    }
}
