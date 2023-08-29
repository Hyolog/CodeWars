using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/596f28fd9be8ebe6ec0000c1/train/csharp"/>
    [TestClass]
    public class WaveSorting
    {
        [TestMethod]
        public void Test()
        {
        }

        public static void WaveSort(int[] arr)
        {
            int anchor = 0;
            int explorer = 1;
            bool isAnchorWaveSorted = false;

            Array.Sort(arr);

            while (explorer < arr.Length)
            {
                if (!isAnchorWaveSorted)
                {
                    Swap(anchor, explorer, arr);
                }
                isAnchorWaveSorted = !isAnchorWaveSorted;
                anchor++;
                explorer++;
            }
        }

        public static void Swap(int i, int j, int[] inputArr)
        {
            int temp = inputArr[i];
            inputArr[i] = inputArr[j];
            inputArr[j] = temp;
        }
    }
}