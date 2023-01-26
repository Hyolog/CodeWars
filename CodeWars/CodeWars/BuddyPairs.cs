using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59ccf051dcc4050f7800008f/train/csharp"/>
    [TestClass]
    public class BuddyPairs
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(Buddy(74, 4429), "(140 195)");
            Assert.AreEqual(Buddy(10, 50), "(48 75)");
            Assert.AreEqual(Buddy(1071625, 1103735), "(1081184 1331967)");
            Assert.AreEqual(Buddy(2382, 3679), "Nothing");
            Assert.AreEqual(Buddy(8983, 13355), "(9504 20735)");
        }

        public static string Buddy(long start, long limit)
        {
            // need to get (n, m) or "Nothing"
            // start <= n <= limit
            // m > n

            // start부터 하나씩(혹은 다른 단위로) 증가하면서 약수의합(Sum(i))을 구한다.
            // Sum(n) = m + 1, Sum(m) = n + 1을 만족하는 m을 찾는다.
            for (var n = start; n < limit; n++)
            {
                var sumN = GetSum(n);
                var m = sumN - 1;

                if (m <= n)
                    continue;

                var sumM = GetSum(m);

                if ((sumN == m + 1) && (sumM == n + 1))
                    return $"({n} {m})";
            }

            return "Nothing";
        }

        public static long GetSum(long number)
        {
            if (number <= 1)
                return number;

            long sum = 1;
            long sqrt = (long)Math.Sqrt(number);

            for (long i = 2; i <= sqrt; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                    sum += number / i;
                }
            }

            if (number == Math.Pow(sqrt, 2))
                sum -= (long)sqrt;

            return sum;
        }
    }
}
