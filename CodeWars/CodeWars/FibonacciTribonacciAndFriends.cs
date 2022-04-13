using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/556e0fccc392c527f20000c5/train/csharp"/>
    /// TODO : Linq로 풀어보기 TakeLast()
    [TestClass]
    public class FibonacciTribonacciAndFriends
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new double[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 }, xbonacci(new double[] { 0, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 }, xbonacci(new double[] { 1, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 0, 0, 0, 0, 1, 1, 2, 4, 8, 16 }, xbonacci(new double[] { 0, 0, 0, 0, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 1, 0, 0, 0, 0, 0, 1, 2, 3, 6 }, xbonacci(new double[] { 1, 0, 0, 0, 0, 0, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 10, 10, 10, 10, 20, 10, 20, 20, 110 }, xbonacci(new double[] { 10, 10, 10, 10, 20, 10, 20, 20 }, 9));
            CollectionAssert.AreEqual(new double[] { 13, 5, 19, 0, 4, 2, 17, 17, 13, 6 }, xbonacci(new double[] { 13, 5, 19, 0, 4, 2, 17, 17, 13, 6 }, 10));
            CollectionAssert.AreEqual(new double[] { 18, 12, 12, 2, 0, 2, 16, 3, 19, 8, 92, 166 }, xbonacci(new double[] { 18, 12, 12, 2, 0, 2, 16, 3, 19, 8 }, 12));
        }

        public double[] xbonacci(double[] signature, int n)
        {
            var result = new double[n];
            var length = signature.Length > n ? n : signature.Length;

            for (int i = 0; i < length; i++)
                result[i] = signature[i];

            for (int i = signature.Length; i < n; i++)
            {
                double nextValue = 0;

                for (int j = i - signature.Length; j < i; j++)
                    nextValue += result[j];

                result[i] = nextValue;
            }

            return result;
        }
    }
}
