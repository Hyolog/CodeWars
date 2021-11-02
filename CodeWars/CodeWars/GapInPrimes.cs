using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/561e9c843a2ef5a40c0000a4/train/csharp"/>
    [TestClass]
    public class GapInPrimes
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new long[] { 101, 103 }, Gap(2, 100, 110));
            CollectionAssert.AreEqual(new long[] { 103, 107 }, Gap(4, 100, 110));
            CollectionAssert.AreEqual(new long[] { 101, 103 }, Gap(2, 100, 103));
            CollectionAssert.AreEqual(null, Gap(6, 100, 110));
            CollectionAssert.AreEqual(new long[] { 359, 367 }, Gap(8, 300, 400));
            CollectionAssert.AreEqual(new long[] { 337, 347 }, Gap(10, 300, 400));
        }

        public long[] Gap(int g, long m, long n)
        {
            for (var i = m; i <= n - g; i++)
            {
                if (IsPrimeNumber(i) && IsPrimeNumber(i + g))
                {
                    // i ~ (i + g) 사이에 소수가 없으면
                    bool existPrimeNumber = false;

                    for (int j = 1; j < g; j++)
                    {
                        if (IsPrimeNumber(i + j))
                        {
                            existPrimeNumber = true;
                            break;
                        }
                    }

                    if (!existPrimeNumber)
                        return new long[] { i, i + g };
                }
            }

            return null;
        }

        private bool IsPrimeNumber(long number)
        {
            for (int i = 2; i * i <= number; i++)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
