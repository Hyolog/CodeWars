using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5d16af632cf48200254a6244/train/csharp"/>
    [TestClass]
    public class StrongestEvenNumberInAnIntervalcs
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(2, StrongestEven(1, 2));
            Assert.AreEqual(8, StrongestEven(5, 10));
            Assert.AreEqual(48, StrongestEven(48, 56));
            Assert.AreEqual(192, StrongestEven(129, 193));
        }

        public static int StrongestEven(int n, int m)
        {
            int maxStrongness = -1;
            int strongestEven = 0;

            for (int i = m; i >= n; i--)
            {
                int strongness = CalculateStrongness(i);

                if (strongness > maxStrongness)
                {
                    maxStrongness = strongness;
                    strongestEven = i;
                }

                i -= strongness;
            }

            return strongestEven;
        }

        static int CalculateStrongness(int num)
        {
            if (num % 2 != 0)
                return 0;

            int strongness = 0;

            while (num > 0 && (num & 1) == 0)
            {
                num >>= 1;
                strongness++;
            }

            return strongness;
        }
    }
}
