using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/578aa45ee9fd15ff4600090d/train/csharp"/>
    [TestClass]
    public class SortTheOdd
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new int[] { 1, 3, 2, 8, 5, 4 }, SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
            CollectionAssert.AreEqual(new int[] { 1, 3, 5, 8, 0 }, SortArray(new int[] { 5, 3, 1, 8, 0 }));
            CollectionAssert.AreEqual(new int[] { }, SortArray(new int[] { }));
        }

        public int[] SortArray(int[] array)
        {
            var orderedOdds = array.Where(d => d % 2 != 0).OrderBy(d => d).ToArray();
            var oddIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    array[i] = orderedOdds[oddIndex];
                    oddIndex++;
                }
            }

            return array;
        }
    }
}
