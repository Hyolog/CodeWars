using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/554ca54ffa7d91b236000023/train/csharp"/>
    [TestClass]
    public class DeleteOccurrencesOfAnElementIfItOccursMoreThanNTimes
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(DeleteNth(new int[] { 20, 37, 20, 21 }, 1), new int[] { 20, 37, 21 });
            CollectionAssert.AreEqual(DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3), new int[] { 1, 1, 3, 3, 7, 2, 2, 2 });
        }

        public static int[] DeleteNth(int[] arr, int x)
        {
            var result = new List<int>();

            if (x == 0)
                return null;

            var check = new Dictionary<int, int>();

            foreach (var item in arr)
            {
                if (check.TryGetValue(item, out var time))
                {
                    if (time < x)
                    {
                        check[item]++;
                        result.Add(item);
                    }
                }
                else
                {
                    check.Add(item, 1);
                    result.Add(item);
                }
            }

            return result.ToArray();
        }

    }
}
