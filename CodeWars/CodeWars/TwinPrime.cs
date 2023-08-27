using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59b7ae14bf10a402d40000f3/train/csharp"/>
    [TestClass]
    public class TwinPrime
    {
        [TestMethod]
        public void Test()
        {
        }

        public static bool IsTwinPrime(int n)
        {
            return IsPrime(n) && (IsPrime(n - 2) || IsPrime(n + 2));
        }

        private static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;
            if (n % 2 == 0 || n % 3 == 0) return false;

            int i = 5;
            while (i * i <= n)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
                i += 6;
            }
            return true;
        }
    }
}
