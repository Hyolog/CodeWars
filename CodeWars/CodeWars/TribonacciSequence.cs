using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/556deca17c58da83c00002db/train/csharp"/>
    [TestClass]
    public class TribonacciSequence
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, Tribonacci(new double[] { 1, 1, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }, Tribonacci(new double[] { 0, 0, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }, Tribonacci(new double[] { 0, 1, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 0 }, Tribonacci(new double[] { 0, 5, 6 }, 1));
        }

        public double[] Tribonacci(double[] signature, int n)
        {
            var result = new double[n];

            for (int i = 0; i < Math.Min(3, n); i++)
                result[i] = signature[i];

            for (int i = 3; i < n; i++)
                result[i] = result[i - 3] + result[i - 2] + result[i - 1];

            return result;
        }
    }
}
