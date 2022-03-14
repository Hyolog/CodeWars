using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5340298112fa30e786000688/train/csharp"/>
    /// TODO: Linq로 다시 풀어보기
    [TestClass]
    public class DifferenceOf2
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new (int, int)[] { (1, 3), (2, 4) }, TwosDifference(new int[] { 1, 2, 3, 4 }));
            CollectionAssert.AreEqual(new (int, int)[] { (1, 3), (4, 6) }, TwosDifference(new int[] { 1, 3, 4, 6 }));
        }

        public static (int, int)[] TwosDifference(int[] array)
        {
            var ordered = array.OrderBy(d => d).ToArray();
            var result = new List<(int, int)>();

            for (int i = 0; i < ordered.Length - 2; i++)
            {
                if (ordered[i] + 2 == ordered[i + 1])
                    result.Add((ordered[i], ordered[i + 1]));
                else if (ordered[i] + 2 == ordered[i + 2])
                    result.Add((ordered[i], ordered[i + 2]));
            }

            if (ordered[ordered.Length - 2] + 2 == ordered[ordered.Length - 1])
                result.Add((ordered[ordered.Length - 2], ordered[ordered.Length - 1]));

            return result.ToArray();
        }
    }
}
