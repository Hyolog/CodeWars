using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5679aa472b8f57fb8c000047/train/csharp"/>
    [TestClass]
    public class EqualSidesOfAnArray
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(3, FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
            Assert.AreEqual(1, FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 }));
            Assert.AreEqual(-1, FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }));
            Assert.AreEqual(3, FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }));
        }

        public static int FindEvenIndex(int[] arr)
        {
            var leftSum = 0;
            var rightSum = arr.Sum() - arr[0];

            if (leftSum == rightSum)
                return 0;

            for (int i = 1; i < arr.Length; i++)
            {
                leftSum += arr[i - 1];
                rightSum -= arr[i];

                if (leftSum == rightSum)
                    return i;
            }

            return -1;
        }
    }
}
