using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59f38b033640ce9fc700015b/train/csharp"/>
    [TestClass]
    public class SumOfPrimeIndexedElements
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(0, solve(new int[] { }));
            Assert.AreEqual(7, solve(new int[] { 1, 2, 3, 4 }));
            Assert.AreEqual(13, solve(new int[] { 1, 2, 3, 4, 5, 6 }));
            Assert.AreEqual(47, solve(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }));
        }

        public static int solve(int[] arr)
        {
            int sum = 0;

            for (int i = 2; i < arr.Length; i++)
            {
                if (IsPrime(i))
                    sum += arr[i];
            }

            return sum;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
