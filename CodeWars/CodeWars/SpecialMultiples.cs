using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55e785dfcb59864f200000d9/train/csharp"/>
    [TestClass]
    public class SpecialMultiples
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(6, CountSpecMult(3, 200));
        }

        public static long CountSpecMult(long n, long mxval)
        {
            long product = 1;
            int prime = 2;

            while (n > 0)
            {
                if (IsPrime(prime))
                {
                    product *= prime;
                    n--;
                }
                prime++;
            }

            return mxval / product;
        }

        public static bool IsPrime(long num)
        {
            if (num <= 1)
                return false;
            if (num == 2)
                return true;
            if (num % 2 == 0)
                return false;

            for (long i = 3; i * i <= num; i += 2)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}
