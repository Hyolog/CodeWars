using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/537529f42993de0e0b00181f/train/csharp"/>
    [TestClass]
    public class CalculateNumberOfInversionsInArray
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(0, CountInversions(new int[] { 1, 2, 3 }), "Sorted array has 0 inversions");
            Assert.AreEqual(1, CountInversions(new int[] { 2, 1, 3 }), "Array [2,1,3] only has one inversion");
        }

        public static int CountInversions(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
