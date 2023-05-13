using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5517fcb0236c8826940003c9/train/csharp"/>
    [TestClass]
    public class IrreducibleSumOfRationals
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(SumFracts(new int[,] { { 1, 2 }, { 2, 9 }, { 3, 18 }, { 4, 24 }, { 6, 48 } }), "[85, 72]");
        }

        public static string SumFracts(int[,] l)
        {
            if (l.Length == 0)
                return null;

            long numerator = 0;
            long denominator = 1;

            for (int i = 0; i < l.GetLength(0); i++)
            {
                numerator = numerator * l[i, 1] + denominator * l[i, 0];
                denominator *= l[i, 1];
            }

            long gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;

            if (denominator == 1)
                return numerator.ToString();

            return $"[{numerator}, {denominator}]";
        }

        private static long GCD(long a, long b)
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}
