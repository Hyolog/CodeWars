using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5a946d9fba1bb5135100007c/train/csharp"/>
    [TestClass]
    public class TransformToPrime
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(1, MinimumNumber(new int[] { 3, 1, 2 }));
            Assert.AreEqual(0, MinimumNumber(new int[] { 5, 2 }));
            Assert.AreEqual(0, MinimumNumber(new int[] { 1, 1, 1 }));
            Assert.AreEqual(5, MinimumNumber(new int[] { 2, 12, 8, 4, 6 }));
            Assert.AreEqual(2, MinimumNumber(new int[] { 50, 39, 49, 6, 17, 28 }));
        }

        public static int MinimumNumber(int[] numbers)
        {
            var sum = numbers.Sum();

            while (true)
            {
                if (IsPrime(sum))
                {
                    return sum - numbers.Sum();
                }

                sum++;
            }
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Pow(number, 0.5); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }    
            }

            return true;
        }
    }
}
