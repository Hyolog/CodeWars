using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5287e858c6b5a9678200083c/train/csharp"/>
    [TestClass]
    public class DoesMyNumberLookBigInThis
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(Narcissistic(1), true);
            Assert.AreEqual(Narcissistic(371), true);
        }

        public bool Narcissistic(int value)
        {
            var candidateNumber = value.ToString();
            var exponential = candidateNumber.Length;
            int sum = 0;

            foreach (var digit in candidateNumber)
                if (char.IsDigit(digit))
                    sum += (int)Math.Pow(int.Parse(digit.ToString()), exponential);

            return value == sum;
        }
    }
}
