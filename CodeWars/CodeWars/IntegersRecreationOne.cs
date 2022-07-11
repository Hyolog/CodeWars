using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55aa075506463dac6600010d/train/csharp"/>
    [TestClass]
    public class IntegersRecreationOne
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.Equals("[[1, 1], [42, 2500], [246, 84100]]", listSquared(1, 250));
            CollectionAssert.Equals("[[42, 2500], [246, 84100]]", listSquared(42, 250));
            CollectionAssert.Equals("[[287, 84100]]", listSquared(250, 500));
        }

        public static string listSquared(long m, long n)
        {
            var result = new List<string>();

            for (var i = m; i <= n; i++)
            {
                var sum = SumOfSquaresOfDivisors(i);

                if (IsSquareNumber(sum))
                {
                    result.Add($"[{i}, {sum}]");
                }
            }

            return $"[{string.Join(", ", result)}]";
        }

        private static long SumOfSquaresOfDivisors(long number)
        {
            double result = 0;

            for (int i = 1; i <= Math.Pow(number, 0.5); i++)
            {
                if (number % i == 0)
                {
                    result += Math.Pow(i, 2);
                    
                    if (Math.Pow(i, 2) != number)
                    {
                        result += Math.Pow(number / i, 2);
                    }
                }
            }

            return (long)result;
        }

        private static bool IsSquareNumber(long number)
        {
            int temp = (int)Math.Pow(number, 0.5);

            return number == (temp * temp);
        }
    }
}
