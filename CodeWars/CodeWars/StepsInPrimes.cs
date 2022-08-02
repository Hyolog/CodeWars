using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5613d06cee1e7da6d5000055/train/csharp"/>
    [TestClass]
    public class StepsInPrimes
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new long[] { 101, 103 }, Step(2, 100, 110));
            CollectionAssert.AreEqual(new long[] { 103, 107 }, Step(4, 100, 110));
            CollectionAssert.AreEqual(new long[] { 101, 107 }, Step(6, 100, 110));
            CollectionAssert.AreEqual(new long[] { 359, 367 }, Step(8, 300, 400));
            CollectionAssert.AreEqual(new long[] { 307, 317 }, Step(10, 300, 400));
            CollectionAssert.AreEqual(null, Step(11, 30000, 100000));
        }

        public static long[] Step(int g, long m, long n)
        {
            for (long i = m; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    if (i + g <= n)
                    {
                        if(IsPrime(i + g))
                        {
                            return new long[] { i, i + g };
                        }
                    }
                }
            }

            return null;
        }

        private static bool IsPrime(long number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Pow(number, 0.5); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
