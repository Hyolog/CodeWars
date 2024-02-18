using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/56060ba7b02b967eb1000013/train/csharp"/>
    [TestClass]
    public class RaiseMeToTheThirdPowerSearchMyDivisors
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(6, IntCubeSumDiv(1));
            Assert.AreEqual(28, IntCubeSumDiv(2));
            Assert.AreEqual(30, IntCubeSumDiv(3));
            Assert.AreEqual(84, IntCubeSumDiv(4));
            Assert.AreEqual(102, IntCubeSumDiv(5));
        }

        // let, F(x) = x의 약수들의 합
        // x^3가 F(x)로 나누어 떨어지는 x중 n번째 수 구하기
        public static long IntCubeSumDiv(long n)
        {
            var index = 1;

            while (n > 0)
            {
                index++;

                if (IsVaild(index))
                    n--;
            }

            return index;
        }

        // n : 1, 2, 3, ... ~
        private static bool IsVaild(long n)
        {
            var thirdPower = Math.Pow(n, 3);
            var sumOfDivisors = SumOfDivisors(n);

            if (thirdPower % sumOfDivisors == 0)
                return true;
            else
                return false;
        }

        static Dictionary<long, long> memo = new Dictionary<long, long>();

        private static long SumOfDivisors(long n)
        {
            if (memo.TryGetValue(n, out var sumOfDiv))
            {
                return sumOfDiv;
            }
            else
            {
                var result = 0;

                for (int i = 1; i <= n / 2; i++)
                    if (n % i == 0)
                        result += i;

                memo[n] = result + n;

                return memo[n];
            }
        }
    }
}
