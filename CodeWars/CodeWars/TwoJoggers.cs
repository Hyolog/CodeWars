using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5274d9d3ebc3030802000165/train/csharp"/>
    [TestClass]
    public class TwoJoggers
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(NbrOfLaps(5, 3), new Tuple<int, int>(3, 5));
            Assert.AreEqual(NbrOfLaps(4, 6), new Tuple<int, int>(3, 2));
            Assert.AreEqual(NbrOfLaps(5, 5), new Tuple<int, int>(1, 1));
        }

        public static Tuple<int, int> NbrOfLaps(int x, int y)
        {
            var lcm = LCM(x, y, GCD(x, y));

            return new Tuple<int, int>(lcm / x, lcm / y);
        }

        private static int GCD(int num1, int num2)
        {
            int temp = 0;

            while (num2 != 0)
            {
                temp = num1 % num2;
                num1 = num2;
                num2 = temp;
            }

            return num1;
        }

        private static int LCM(int num1, int num2, int gcd)
        {
            if (gcd == 0) 
                return 0;

            return (num1 * num2) / gcd;
        }
    }
}
