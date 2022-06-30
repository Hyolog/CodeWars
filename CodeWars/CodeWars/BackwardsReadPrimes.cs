using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5539fecef69c483c5a000015/train/csharp"/>
    [TestClass]
    public class BackwardsReadPrimes
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("13 17 31 37 71 73 79 97", backwardsPrime(1, 100));
            Assert.AreEqual("9923 9931 9941 9967", backwardsPrime(9900, 10000));
        }
        public static string backwardsPrime(long start, long end)
        {
            var primes = new List<long>();

            for (var i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    var reverseNumber = long.Parse(new string(i.ToString().Reverse().ToArray()));

                    if (reverseNumber != i && IsPrime(reverseNumber))
                    {
                        primes.Add(i);
                    }
                }
            }

            return string.Join(" ", primes);
        }

        private static bool IsPrime(long number)
        {
            if (number < 2)
                return false;

            for (int j = 2; j <= Math.Pow(number, 0.5); j++)
            {
                if (number % j == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
