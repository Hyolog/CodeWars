using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59ec2d112332430ce9000005/train/csharp"/>
    [TestClass]
    public class SimpleDivision
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(Solve(15, 12), false);
            Assert.AreEqual(Solve(2, 256), true);
            Assert.AreEqual(Solve(2, 253), false);
            Assert.AreEqual(Solve(9, 243), true);
            Assert.AreEqual(Solve(21, 2893401), true);
            Assert.AreEqual(Solve(21, 2893406), false);
            Assert.AreEqual(Solve(54, 2834352), true);
            Assert.AreEqual(Solve(54, 2834359), false);
            Assert.AreEqual(Solve(1000013, 7187761), true);
            Assert.AreEqual(Solve(1000013, 7187762), false);
        }

        public static bool Solve(int a, int b)
        {
            var primes = GerPrimes(b).Distinct();

            foreach (var prime in primes)
            {
                if (a % prime != 0)
                    return false;
            }

            return true;
        }

        private static List<int> GerPrimes(int number)
        {
            List<int> primeFactors = new List<int>();

            while (number % 2 == 0)
            {
                primeFactors.Add(2);
                number /= 2;
            }

            for (int i = 3; i <= number; i += 2)
            {
                while (number % i == 0)
                {
                    primeFactors.Add(i);
                    number /= i;
                }
            }

            return primeFactors;
        }
    }
}
