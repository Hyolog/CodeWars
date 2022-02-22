using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55eeddff3f64c954c2000059/train/csharp"/>
    [TestClass]
    public class SumConsecutives
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(SumConsecutivesFunc(new List<int> { 1, 4, 4, 4, 0, 4, 3, 3, 1 }), new List<int> { 1, 12, 0, 4, 6, 1 });
            CollectionAssert.AreEqual(SumConsecutivesFunc(new List<int> { -5, -5, 7, 7, 12, 0 }), new List<int> { -10, 14, 12, 0 });
        }

        public static List<int> SumConsecutivesFunc(List<int> s)
        {
            var result = new List<int>();
            var pivot = s.First();
            var sum = pivot;

            for (int i = 1; i < s.Count; i++)
            {
                if (s[i] == pivot)
                    sum += s[i];
                else
                {
                    result.Add(sum);
                    pivot = s[i];
                    sum = pivot;
                }
            }

            result.Add(sum);

            return result;
        }
    }
}
