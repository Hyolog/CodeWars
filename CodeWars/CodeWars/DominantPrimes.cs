using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59ce11ea9f0cbc8a390000ed/train/csharp"/>
    [TestClass]
    public class DominantPrimes
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(8, solve(0, 10));
            Assert.AreEqual(1080, solve(2, 200));
            Assert.AreEqual(48132, solve(200, 2000));
            Assert.AreEqual(52114889, solve(1000, 100000));
            Assert.AreEqual(972664400, solve(4000, 500000));
        }

        public static int solve(int a, int b)
        {
            var index = 0;
            var result = 0;

            for (int i = 0; i <= b; i++)
            {
                if (IsPrime(i))
                {
                    index++;

                    if (i >= a && IsPrime(index))
                    {
                        result += i;
                    }
                }
            }

            return result;
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
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
