using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5262119038c0985a5b00029f/train/csharp"/>
    [TestClass]
    public class IsANumberPrime
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(IsPrime(0), false);
            Assert.AreEqual(IsPrime(1), false);
            Assert.AreEqual(IsPrime(2), true);
            Assert.AreEqual(IsPrime(-1), false);
        }

        public bool IsPrime(int n)
        {
            Console.WriteLine(n);

            if (n < 2)
                return false;

            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
}
