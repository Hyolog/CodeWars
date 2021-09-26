using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5279f6fe5ab7f447890006a7/train/csharp"/>
    /// TODO : 생각보다 고려해야할게 많음
    /// TODO : How to compare Dictionary<string, List<int>> result?
    [TestClass]
    public class PickPeaks
    {
        [TestMethod]
        public void Test()
        {
            //CollectionAssert.AreEquivalent(GetPeaks(new int[] { 2, 1, 3, 2, 2, 2, 2, 5, 6, 8 }),
            //    new Dictionary<string, List<int>>() { { "pos", new List<int>() { 2 } }, { "peaks", new List<int>() { 3 } } });
            //CollectionAssert.AreEquivalent(GetPeaks(new int[] { 2, 1, 3, 2, 2, 2, 2, 1 }),
            //    new Dictionary<string, List<int>>() { { "pos", new List<int>() { 2 } }, { "peaks", new List<int>() { 3 } } });
            //CollectionAssert.AreEquivalent(GetPeaks(new int[] { 1, 2, 3, 6, 4, 1, 2, 3, 2, 1 }),
            //    new Dictionary<string, List<int>>() { { "pos", new List<int>() { 3, 7 } }, { "peaks", new List<int>() { 6, 3 } } });
            //CollectionAssert.AreEquivalent(GetPeaks(new int[] { 3, 2, 3, 6, 4, 1, 2, 3, 2, 1, 2, 3 }),
            //    new Dictionary<string, List<int>>() { { "pos", new List<int>() { 3, 7 } }, { "peaks", new List<int>() { 6, 3 } } });
            //CollectionAssert.AreEquivalent(GetPeaks(new int[] { 3, 2, 3, 6, 4, 1, 2, 3, 2, 1, 2, 2, 2, 1 }),
            //    new Dictionary<string, List<int>>() { { "pos", new List<int>() { 3, 7, 10 } }, { "peaks", new List<int>() { 6, 3, 2 } } });
            //CollectionAssert.AreEquivalent(GetPeaks(new int[] { 2, 1, 3, 1, 2, 2, 2, 2, 1 }),
            //    new Dictionary<string, List<int>>() { { "pos", new List<int>() { 2, 4 } }, { "peaks", new List<int>() { 3, 2 } } });
            //CollectionAssert.AreEquivalent(GetPeaks(new int[] { 2, 1, 3, 1, 2, 2, 2, 2 }),
            //    new Dictionary<string, List<int>>() { { "pos", new List<int>() { 2 } }, { "peaks", new List<int>() { 3 } } });
        }

        public Dictionary<string, List<int>> GetPeaks(int[] arr)
        {
            var positions = new List<int>();
            var peaks = new List<int>();
            var candidateIndex = -1;

            for (int i = 2; i < arr.Length; i++)
            {
                // 값이 감소하는 케이스
                if (arr[i - 1] > arr[i])
                {
                    if (arr[i - 2] < arr[i - 1])
                    {
                        positions.Add(i - 1);
                        peaks.Add(arr[i - 1]);
                    }
                    else if (arr[i - 2].Equals(arr[i - 1]))
                    {
                        if (candidateIndex != -1)
                        {
                            positions.Add(candidateIndex);
                            peaks.Add(arr[candidateIndex]);
                        }
                    }
                }

                // 값이 그대로인 경우
                else if (arr[i - 1].Equals(arr[i]))
                {
                    // 이전에 값이 증가하고 있었으면 임시 기록
                    if (arr[i - 2] < arr[i - 1])
                        candidateIndex = i - 1;
                }
            }

            return new Dictionary<string, List<int>>() { { "pos", positions }, { "peaks", peaks } };
        }
    }
}
