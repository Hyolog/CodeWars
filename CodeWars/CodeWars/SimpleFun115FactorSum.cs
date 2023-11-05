using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/589d2bf7dfdef0817e0001aa/train/csharp"/>
    [TestClass]
    public class SimpleFun115FactorSum
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(5, FactorSum(24));
            Assert.AreEqual(7, FactorSum(35));
            Assert.AreEqual(5, FactorSum(156));
            Assert.AreEqual(4, FactorSum(4));
            Assert.AreEqual(31, FactorSum(31));
        }

        public int FactorSum(int n)
        {
            int result = n;
            int lastResult = 0;

            while (result != lastResult)
            {
                lastResult = result;
                result = SumPrimeFactors(result);
            }

            return result;
        }

        public static int SumPrimeFactors(int n)
        {
            int sum = 0;
            int divisor = 2;

            while (n > 1)
            {
                if (n % divisor == 0)
                {
                    sum += divisor;
                    n /= divisor;
                }
                else
                {
                    divisor++;
                }
            }

            return sum;
        }
    }
}
