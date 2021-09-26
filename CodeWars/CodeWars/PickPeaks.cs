using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5279f6fe5ab7f447890006a7/train/csharp"/>
    [TestClass]
    public class PickPeaks
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(GetPeaks(new int[] { 1, 2, 3, 6, 4, 1, 2, 3, 2, 1 }),
                new Dictionary<string, List<int>>() { { "pos", new List<int>() { 3, 7 } }, { "peaks", new List<int>() { 6, 3 } } });
            CollectionAssert.AreEqual(GetPeaks(new int[] { 3, 2, 3, 6, 4, 1, 2, 3, 2, 1, 2, 3 }),
                new Dictionary<string, List<int>>() { { "pos", new List<int>() { 3, 7 } }, { "peaks", new List<int>() { 6, 3 } } });
            CollectionAssert.AreEqual(GetPeaks(new int[] { 3, 2, 3, 6, 4, 1, 2, 3, 2, 1, 2, 2, 2, 1 }),
                new Dictionary<string, List<int>>() { { "pos", new List<int>() { 3, 7, 10 } }, { "peaks", new List<int>() { 6, 3, 2 } } });
            CollectionAssert.AreEqual(GetPeaks(new int[] { 2, 1, 3, 1, 2, 2, 2, 2, 1 }),
                new Dictionary<string, List<int>>() { { "pos", new List<int>() { 2, 4 } }, { "peaks", new List<int>() { 3, 2 } } });
            CollectionAssert.AreEqual(GetPeaks(new int[] { 2, 1, 3, 1, 2, 2, 2, 2 }),
                new Dictionary<string, List<int>>() { { "pos", new List<int>() { 2 } }, { "peaks", new List<int>() { 3 } } });
        }

        public Dictionary<string, List<int>> GetPeaks(int[] arr)
        {
            var positions = new List<int>();
            var peaks = new List<int>();
            var candidateIndex = -1;

            if (arr.Length < 3)
                return new Dictionary<string, List<int>>() { { "pos", positions }, { "peaks", peaks } };

            for (int i = 2; i < arr.Length; i++)
            {
                // ���� �����ϴ� ���̽���
                if (arr[i - 1] > arr[i])
                {
                    // �� �� ���� �����ϰ� �־����� = ������
                    if (arr[i - 2] < arr[i - 1])
                    {
                        positions.Add(i - 1);
                        peaks.Add(arr[i - 1]);
                    }
                    // ������
                    else if (arr[i - 2].Equals(arr[i - 1]))
                    {
                        positions.Add(candidateIndex);
                        peaks.Add(arr[candidateIndex]);
                    }
                }

                // ���� �״���� ���
                if (arr[i - 1].Equals(arr[i]))
                {
                    // ������ ���� �����ϰ� �־����� �ӽ� ���
                    if (arr[i - 2] < arr[i - 1])
                    {
                        candidateIndex = i - 1;
                    }
                }
            }

            return new Dictionary<string, List<int>>() { { "pos", positions }, { "peaks", peaks } };
        }
    }
}
