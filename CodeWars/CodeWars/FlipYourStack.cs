using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/6472390e0d0bb1001d963536/train/csharp"/>
    [TestClass]
    public class FlipYourStack
    {
        [TestMethod]
        public void Test()
        {
            // 1, 5, 8,* 3
            // 8, 5, 1, 3 *
            // 3, 1*, 5, 8
            // 1, 3, 5, 8
            CollectionAssert.AreEqual(FlipPancakes(new List<int>() { 1, 5, 8, 3 }), new List<int>() { 2, 3, 1 });
        }

        public static List<int> FlipPancakes(List<int> pancakes)
        {
            List<int> flips = new List<int>();
            int n = pancakes.Count;

            for (int size = n; size > 1; size--)
            {
                int maxIndex = FindMaxIndex(pancakes, size);

                if (maxIndex != size - 1)
                {
                    if (maxIndex != 0)
                    {
                        Flip(pancakes, maxIndex);
                        flips.Add(maxIndex);
                    }

                    Flip(pancakes, size - 1);
                    flips.Add(size - 1);
                }
            }

            return flips;
        }

        private static int FindMaxIndex(List<int> pancakes, int size)
        {
            int maxIndex = 0;
            for (int i = 1; i < size; i++)
            {
                if (pancakes[i] > pancakes[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        private static void Flip(List<int> pancakes, int index)
        {
            int start = 0;
            while (start < index)
            {
                int temp = pancakes[start];
                pancakes[start] = pancakes[index];
                pancakes[index] = temp;
                start++;
                index--;
            }
        }
    }
}
