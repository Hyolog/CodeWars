using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/6329d94bf18e5d0e56bfca77/train/csharp"/>
    [TestClass]
    public class PageReplacementAlgorithmsLRU
    {
        [TestMethod]
        public void Test()
        {
            List<List<int>> referenceLists = new List<List<int>>(new List<int>[]{
                new List<int>(new int[]{1, 2, 3, 4, 3, 2, 5}),
                new List<int>(new int[]{}),
                new List<int>(new int[]{5, 4, 3, 2, 3, 5, 2, 6, 7, 8}),
                new List<int>(new int[]{1, 1, 1, 2, 2, 3}),
                new List<int>(new int[]{5, 4, 3, 3, 4, 10}),
                new List<int>(new int[]{1, 1, 1, 1, 1, 1, 1, 1}),
                new List<int>(new int[]{10, 9, 8, 7, 7, 8, 7, 6, 5, 4, 3, 4, 3, 4, 5, 6, 5})
            });

            List<List<int>> results = new List<List<int>>(new List<int>[]{
                new List<int>(new int[]{5, 2, 3}),
                new List<int>(new int[]{-1, -1, -1, -1, -1}),
                new List<int>(new int[]{8, 6, 7, 2}),
                new List<int>(new int[]{1, 2, 3, -1}),
                new List<int>(new int[]{10}),
                new List<int>(new int[]{1, -1, -1}),
                new List<int>(new int[]{5, 4, 3, 7, 6})
            });

            int[] ns = new int[] { 3, 5, 4, 4, 1, 3, 5 };

            for (int i = 0; i < referenceLists.Count; i++)
            {
                string referenceListString = string.Join(", ", referenceLists[i]);
                string expectedString = string.Join(", ", results[i]);

                List<int> actual = Lru(ns[i], new List<int>(referenceLists[i]));
                string actualString = string.Join(", ", actual);

                if (!results[i].SequenceEqual(actual))
                    Assert.Fail($"N = {ns[i]}, REFERENCE LIST = [{referenceListString}]: [{actualString}] should equal [{expectedString}]");
            }
        }

        public static List<int> Lru(int n, List<int> referenceList)
        {
            List<int> memory = new List<int>(n);
            List<int> recentUsage = new List<int>();

            foreach (int page in referenceList)
            {
                if (memory.Contains(page))
                {
                    recentUsage.Remove(page);
                    recentUsage.Add(page);
                }
                else
                {
                    if (memory.Count < n)
                    {
                        memory.Add(page);
                    }
                    else
                    {
                        int lruPage = recentUsage[0];
                        memory[memory.IndexOf(lruPage)] = page;
                        recentUsage.RemoveAt(0);
                    }
                    recentUsage.Add(page);
                }
            }

            while (memory.Count < n)
            {
                memory.Add(-1);
            }

            return memory;
        }
    }
}