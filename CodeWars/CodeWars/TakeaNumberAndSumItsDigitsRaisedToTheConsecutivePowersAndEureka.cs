using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5626b561280a42ecc50000d1/train/csharp"/>
    [TestClass]
    public class TakeaNumberAndSumItsDigitsRaisedToTheConsecutivePowersAndEureka
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(SumDigPow(1, 10), new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            CollectionAssert.AreEqual(SumDigPow(1, 100), new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 89 });
            CollectionAssert.AreEqual(SumDigPow(10, 100), new long[] { 89 });
            CollectionAssert.AreEqual(SumDigPow(90, 100), new long[] { });
            CollectionAssert.AreEqual(SumDigPow(90, 150), new long[] { 135 });
        }

        public long[] SumDigPow(long a, long b)
        {
            var result = new List<long>();

            for (var i = a; i <= b; i++)
                if (IsEurekaNumber(i))
                    result.Add(i);

            return result.ToArray();
        }

        private bool IsEurekaNumber(long number)
        {
            var stringNum = number.ToString();

            var result = 0;

            for (int i = 0; i < stringNum.Length; i++)
                result += (int)Math.Pow(int.Parse(stringNum[i].ToString()), i + 1);

            return result == number;
        }
    }
}
