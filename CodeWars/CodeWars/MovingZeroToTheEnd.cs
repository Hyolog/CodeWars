using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/52597aa56021e91c93000cb0"/>
    [TestClass]
    public class MovingZeroToTheEnd
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
        }

        public int[] MoveZeroes(int[] arr)
        {
            int countOfZero = 0;
            List<int> result = new List<int>();

            foreach (var item in arr)
            {
                if (item.Equals(0))
                    countOfZero++;
                else
                    result.Add(item);
            }

            for (int i = 0; i < countOfZero; i++)
                result.Add(0);

            return result.ToArray();
        }
    }
}
