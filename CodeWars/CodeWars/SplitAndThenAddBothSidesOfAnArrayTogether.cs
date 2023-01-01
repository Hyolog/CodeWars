using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5946a0a64a2c5b596500019a/train/csharp"/>
    [TestClass]
    public class SplitAndThenAddBothSidesOfAnArrayTogether
    {
        [TestMethod]
        public void Test()
        {
            int[] expected = new int[] { 5, 10 };
            int[] input = SplitAndAdd(new int[] { 1, 2, 3, 4, 5 }, 2);

            CollectionAssert.AreEqual(expected, input);

            expected = new int[] { 15 };
            input = SplitAndAdd(new int[] { 1, 2, 3, 4, 5 }, 3);

            CollectionAssert.AreEqual(expected, input);

            expected = new int[] { 15 };
            input = SplitAndAdd(new int[] { 15 }, 3);

            CollectionAssert.AreEqual(expected, input);

            expected = new int[] { 183, 125 };
            input = SplitAndAdd(new int[] { 32, 45, 43, 23, 54, 23, 54, 34 }, 2);

            CollectionAssert.AreEqual(expected, input);

            expected = new int[] { 32, 45, 43, 23, 54, 23, 54, 34 };
            input = SplitAndAdd(new int[] { 32, 45, 43, 23, 54, 23, 54, 34 }, 0);

            CollectionAssert.AreEqual(expected, input);

            expected = new int[] { 305, 1195 };
            input = SplitAndAdd(new int[] { 3, 234, 25, 345, 45, 34, 234, 235, 345 }, 3);

            CollectionAssert.AreEqual(expected, input);

            expected = new int[] { 1040, 7712 };
            input = SplitAndAdd(new int[] { 3, 234, 25, 345, 45, 34, 234, 235, 345, 34, 534, 45, 645, 645, 645, 4656, 45, 3 }, 4);

            CollectionAssert.AreEqual(expected, input);

            expected = new int[] { 79327 };
            input = SplitAndAdd(new int[] { 23, 345, 345, 345, 34536, 567, 568, 6, 34536, 54, 7546, 456 }, 20);

            CollectionAssert.AreEqual(expected, input);
        }

        public static int[] SplitAndAdd(int[] numbers, int n)
        {
            for (int i = 0; i < n; i++)
                numbers = Divide(numbers);

            return numbers;
        }

        private static int[] Divide(int[] numbers)
        {
            var result = new List<int>();
            var index = numbers.Length / 2;

            if (numbers.Length % 2 == 0)
            {
                for (int i = 0; i < index; i++)
                    result.Add(numbers[i] + numbers[i + index]);
            }
            else
            {
                result.Add(numbers[index]);

                for (int i = 0; i < index; i++)
                    result.Add(numbers[i] + numbers[i + index + 1]);
            }

            return result.ToArray();
        }
    }
}
