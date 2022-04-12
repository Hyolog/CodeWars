using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/52c31f8e6605bcc646000082/train/csharp"/>
    [TestClass]
    public class TwoSum
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new[] { 0, 2 }, TwoSumFunc(new[] { 1, 2, 3 }, 4).OrderBy(a => a).ToArray());
            CollectionAssert.AreEqual(new[] { 1, 2 }, TwoSumFunc(new[] { 1234, 5678, 9012 }, 14690).OrderBy(a => a).ToArray());
            CollectionAssert.AreEqual(new[] { 0, 1 }, TwoSumFunc(new[] { 2, 2, 3 }, 4).OrderBy(a => a).ToArray());
        }

        List<int> result = new List<int>();

        public static int[] TwoSumFunc(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
                for (int j = i + 1; j < numbers.Length; j++)
                    if (numbers[i] + numbers[j] == target)
                        return new int[] { i, j };

            return null;
        }
    }
}
